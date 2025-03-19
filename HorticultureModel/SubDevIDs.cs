using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.HorticultureModel
{
    public class SubDevIDs
    {
        private byte[] bytes = new byte[320];
        public bool Load(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 320) return false;
            for (int i = 0; i < bytes.Length; i++)
            {
                this.bytes[i] = bytes[i];
            }
            Loaded?.Invoke(this, EventArgs.Empty);
            return true;
        }
        public byte[] GetBytes()
        {
            return bytes;
        }
        public uint GetSensorID(int index)
        {
            if (index < 0 || index > 15) return 0;
            return BitConverter.ToUInt32(bytes, index * 4) | 0x80000000;
        }
        public string GetSensorIDString(int index)
        {
            if (index < 0 || index > 15) return string.Empty;
            return string.Join("-", bytes.Skip(index * 4).Take(4).Reverse().Select(b => b.ToString("X2")));
        }
        public void SetSensorID(int index, uint value)
        {
            if (index < 0 || index > 15) return;
            BitConverter.GetBytes(value).CopyTo(bytes, index * 4);
        }
        public bool IsSensorOn(int index)
        {
            if (index < 0 || index > 15) return false;
            return BitConverter.ToUInt32(bytes, index * 4) > 0x7FFFFFFF;
        }
        public void SensorOn(int index, bool value)
        {
            if (index < 0 || index > 15) return;
            if (value)
            {
                BitConverter.GetBytes(BitConverter.ToUInt32(bytes, index * 4) | 0x80000000).CopyTo(bytes, index * 4);
            }
            else
            {
                BitConverter.GetBytes(BitConverter.ToUInt32(bytes, index * 4) & 0x7FFFFFFF).CopyTo(bytes, index * 4);
            }
        }
        public uint GetLightID(int index)
        {
            if (index < 0 || index > 63) return 0;
            return BitConverter.ToUInt32(bytes, 64 + index * 4) | 0x80000000;
        }
        public string GetLightIDString(int index)
        {
            if (index < 0 || index > 63) return string.Empty;
            return string.Join("-", bytes.Skip(64 + index * 4).Take(4).Reverse().Select(b => b.ToString("X2")));
        }
        public void SetLightID(int index, uint value)
        {
            if (index < 0 || index > 63) return;
            value = IsLightOn(index) ? value | 0x80000000 : value & 0x7FFFFFFF;
            BitConverter.GetBytes(value).CopyTo(bytes, 64 + index * 4);
        }
        public bool IsLightOn(int index)
        {
            if (index < 0 || index > 63) return false;
            return BitConverter.ToUInt32(bytes, 64 + index * 4) > 0x7FFFFFFF;
        }
        public void LightOn(int index, bool value)
        {
            if (index < 0 || index > 63) return;
            if (value)
            {
                BitConverter.GetBytes(BitConverter.ToUInt32(bytes, 64 + index * 4) | 0x80000000).CopyTo(bytes, 64 + index * 4);
            }
            else
            {
                BitConverter.GetBytes(BitConverter.ToUInt32(bytes, 64 + index * 4) & 0x7FFFFFFF).CopyTo(bytes, 64 + index * 4);
            }
        }
        public event EventHandler? Loaded;
    }
}
