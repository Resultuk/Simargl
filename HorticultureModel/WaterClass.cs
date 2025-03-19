using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.HorticultureModel
{
    public class WaterClass
    {
        private byte[] bytes = new byte[64];
        public bool Load(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 64) return false;
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
        public ushort Mode { get => BitConverter.ToUInt16(bytes, 0); set => BitConverter.GetBytes(value).CopyTo(bytes, 0); }
        public ushort SwitchToAuto { get => BitConverter.ToUInt16(bytes, 2); set => BitConverter.GetBytes(value).CopyTo(bytes, 2); }
        public ushort WorkTime { get => BitConverter.ToUInt16(bytes, 4); set => BitConverter.GetBytes(value).CopyTo(bytes, 4); }
        public ushort RepeatTime { get => BitConverter.ToUInt16(bytes, 6); set => BitConverter.GetBytes(value).CopyTo(bytes, 6); }
        public DateTime Start
        {
            get => DateTime.UnixEpoch.AddSeconds(BitConverter.ToUInt32(bytes, 8));
            set => BitConverter.GetBytes((UInt32)((DateTime)value - DateTime.UnixEpoch).TotalSeconds).ToArray().CopyTo(bytes, 8);
        }
        public DateTime Finish
        {
            get => DateTime.UnixEpoch.AddSeconds(BitConverter.ToUInt32(bytes, 12));
            set => BitConverter.GetBytes((UInt32)((DateTime)value - DateTime.UnixEpoch).TotalSeconds).ToArray().CopyTo(bytes, 12);
        }
        public bool DoNotStop
        {
            get => BitConverter.ToUInt32(bytes, 12) == uint.MaxValue;
            set
            {
                if (value)
                {
                    BitConverter.GetBytes(uint.MaxValue).Reverse().ToArray().CopyTo(bytes, 12);
                }
                else
                {
                    if (BitConverter.ToUInt32(bytes, 12) == uint.MaxValue) Finish = new DateTime(Finish.AddYears(DateTime.Now.Year - 2106 + 1).Year, 1, 1);
                }
            }
        }
        public ushort Flags { get => BitConverter.ToUInt16(bytes, 16); set => BitConverter.GetBytes(value).CopyTo(bytes, 16); }
        public ushort MinLevel { get => BitConverter.ToUInt16(bytes, 18); set => BitConverter.GetBytes(value).CopyTo(bytes, 18); }
        public ushort MaxLevel { get => BitConverter.ToUInt16(bytes, 20); set => BitConverter.GetBytes(value).CopyTo(bytes, 20); }
        public byte LevelNetAddress { get => bytes[22]; set => bytes[22] = value; }
        public bool LevelOn
        {
            get => (bytes[22] & 0b10000000) > 0;
            set => bytes[22] = (byte)(value ? bytes[22] | 0b10000000 : bytes[22] & 0b01111111);
        }
        public event EventHandler? Loaded;
    }
}
