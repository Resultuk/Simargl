using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Growor.Recipe
{
    public class Recipe : BaseClass
    {
        private string name = string.Empty;
        private string description = string.Empty;
        public BindingList<Phase> phases;
        public string Name { get => name; set { name = value; OnPropertyChanged(nameof(Name)); } }
        public string Description { get => description; set { description = value; OnPropertyChanged(nameof(Description)); } }
        public BindingList<Phase> Phases 
        { 
            get => phases;
            set
            {
                phases = value;
                phases.ListChanged += (s, e) => OnPropertyChanged(nameof(Phase));
                foreach (var phase in phases)
                {
                    phase.PropertyChanged += (s, e) => { OnPropertyChanged(nameof(Phases)); };
                }
            }
        }
        public Recipe()
        {
            phases = [];
            phases.ListChanged += (s, e) => OnPropertyChanged(nameof(Phase));
        }
        public void AddPhase(Phase phase = null)
        {
            phase ??= new Phase();
            phase.PropertyChanged += (s, e) => { OnPropertyChanged(nameof(Phases)); };
            phases.Add(phase);
        }
    }
    public class Phase : BaseClass, ICloneable
    {
        #region Fields
        private string name = "New phase";
        private uint duration = 1440;
        private BindingList<Period> lighting = [];
        private BindingList<Period> watering = [];
        private BindingList<Period> feeding = [];
        private BindingList<Period> blowing = [];
        private BindingList<Period> controls = [];
        #endregion
        #region Properties
        public string Name { get => name; set { name = value; OnPropertyChanged(nameof(Name)); } }
        public uint Duration { get => duration; set { duration = value; OnPropertyChanged(nameof(Duration)); } }
        public BindingList<Period> Lighting 
        {
            get => lighting;
            set
            {
                lock (lighting)
                {
                    lighting = value;
                    lighting.ListChanged += (s, e) => OnPropertyChanged(nameof(Phase));
                    foreach (var light in lighting)
                    {
                        light.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Lighting)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        public BindingList<Period> Watering 
        { 
            get => watering;
            set
            {
                lock (watering)
                {
                    watering = value;
                    foreach (var water in watering)
                    {
                        water.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Watering)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        public BindingList<Period> Feeding 
        { 
            get => feeding;
            set
            {
                lock (feeding)
                {
                    feeding = value;
                    foreach (var feed in feeding)
                    {
                        feed.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Feeding)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        public BindingList<Period> Blowing 
        {
            get => blowing;
            set
            {
                lock (blowing)
                {
                    blowing = value;
                    foreach (var blow in blowing)
                    {
                        blow.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Blowing)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        public BindingList<Period> Controls 
        { 
            get => controls;
            set
            {
                lock (controls)
                {
                    controls = value;
                    foreach (var control in controls)
                    {
                        control.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Controls)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        #endregion
        #region Method
        public void Add(ActionsType type, object obj = null)
        {
            switch (type)
            {
                case ActionsType.Lighting: 
                    obj ??= new Period(); Lighting.Add((Period)obj);
                    ((BaseClass)obj).PropertyChanged += (s, e) => { OnPropertyChanged(nameof(Lighting)); };
                    break;
                case ActionsType.Watering:
                    obj ??= new Period(); Watering.Add((Period)obj);
                    ((BaseClass)obj).PropertyChanged += (s, e) => { OnPropertyChanged(nameof(Watering)); };
                    break;
                case ActionsType.Feeding:
                    obj ??= new Period(); Feeding.Add((Period)obj);
                    ((BaseClass)obj).PropertyChanged += (s, e) => { OnPropertyChanged(nameof(Feeding)); };
                    break;
                case ActionsType.Blowing:
                    obj ??= new Period(); Blowing.Add((Period)obj);
                    ((BaseClass)obj).PropertyChanged += (s, e) => { OnPropertyChanged(nameof(Blowing)); };
                    break;
            }
        }
        public void CalcLight()
        {
            lock (Lighting)
                if (Lighting.Count > 1)
                    for (int i = 1; i < Lighting.Count; i++)
                    {
                        Lighting[i].StartTime = Lighting[i - 1].StartTime + Lighting[i - 1].Duration;
                    }
        }
        public object Clone()
        {
            return new Phase()
            {
                Name = name,
                Duration = duration,
                Lighting = new BindingList<Period>(lighting.Select(x => (Period)x.Clone()).ToArray()),
                Watering = new BindingList<Period>(watering.Select(x => (Period)x.Clone()).ToArray()),
                Feeding = new BindingList<Period>(feeding.Select(x => (Period)x.Clone()).ToArray()),
                Blowing = new BindingList<Period>(blowing.Select(x => (Period)x.Clone()).ToArray()),
                Controls = new BindingList<Period>(controls.Select(x => (Period)x.Clone()).ToArray()),
            };
        }
        #endregion
    }
    public class Period : BaseClass, ICloneable
    {
        #region Field
        private uint startTime;
        private uint duration;
        private uint repeat;
        private BindingList<Control> controls = [];
        private BindingList<Action> actions = [];
        #endregion
        #region Constructor
        #endregion
        #region Properties
        public uint StartTime { get => startTime; set { startTime = value; OnPropertyChanged(nameof(StartTime)); } }
        public uint Duration { get => duration; set { duration = value; OnPropertyChanged(nameof(Duration)); } }
        public uint Repeat { get => repeat; set { repeat = value; OnPropertyChanged(nameof(Repeat)); } }
        public BindingList<Control> Controls 
        { 
            get => controls;
            set
            {
                lock (controls)
                {
                    controls = value;
                    foreach (var control in controls)
                    {
                        control.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Controls)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        public BindingList<Action> Actions 
        { 
            get => actions;
            set
            {
                lock (actions)
                {
                    actions = value;
                    foreach (var action in actions)
                    {
                        action.PropertyChanged += (s, e) => { OnPropertyChanged($"{nameof(Actions)}/{e.PropertyName}"); };
                    }
                }
            }
        }
        public object Clone()
        {
            var result = (Period)this.MemberwiseClone();
            result.Controls = new BindingList<Control>(controls.Select(c => (Control)c.Clone()).ToList());
            result.Actions = new BindingList<Action>(actions.Select(a => (Action)a.Clone()).ToList());
            return result;
        }
        #endregion
    }
    public class Action : BaseParam, ICloneable
    {
        private float _value;
        public float Value { get => _value; set { _value = value; OnPropertyChanged(nameof(Value)); } }
        public new object Clone()
        {
            return new Action() { Description = Description, Value = _value, Name = Name, Reduction = Reduction, UnitOfMeasure = UnitOfMeasure };
        }
    }
    public class Control : BaseParam, ICloneable
    {
        private Interval interval;

        public Interval Interval { get => interval; set { interval = value; } }
        public new object Clone()
        {
            return new Control() { Description = Description, Interval = (Interval)Interval.Clone(), Name = Name, Reduction = Reduction, UnitOfMeasure = UnitOfMeasure };
        }
    }
    public class Interval : BaseClass, ICloneable
    {
        #region Fields
        private float min;
        private float max;
        #endregion
        #region Properties
        public float Min { get => min; set { min = value; OnPropertyChanged(nameof(Min)); } }
        public float Max { get => max; set { max = value; OnPropertyChanged(nameof(Max)); } }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }
    public class PhaseInfo : IGuidable
    {
        public Phase Phase { get; set; }
        public string Name
        {
            get
            {
                return Phase.Name;
            }
            set
            {
                Phase.Name = value;
            }
        }
        public string Duration
        {
            get
            {
                return $"{Phase.Duration / 60:D2}:{Phase.Duration % 60:D2}";
            }
            set
            {
                var strs = value.Split(':');
                switch (strs.Length)
                {
                    case 0: return;
                    case 1: if (uint.TryParse(strs[0], out uint hour)) Phase.Duration = hour * 60; return;
                    default:
                        if (uint.TryParse(strs[0], out hour))
                            if (uint.TryParse(strs[1], out uint minute)) 
                                Phase.Duration = hour * 60 + minute;
                    return;
                }
            }
        }

        public Guid GetGuid()
        {
            return Phase.Guid;
        }
    }
    public class CategoryInfo : IGuidable
    {
        
        public BindingList<Period> Periods { get; set; }
        public string Name { get; set; }
        public string Duration
        {
            get
            {
                var result = Periods.Select(P => P.Duration).Sum(x => x);
                return $"{result / 60:D2}:{result % 60:D2}";
            }
        }

        private static readonly Guid guid = Guid.NewGuid();
        public Guid GetGuid()
        {
            return guid;
        }
    }
    public class PeriodInfo : IGuidable
    {
        public Period Period { get; set; }
        public string Name 
        { 
            get => $"{Period.StartTime / 60:D2}:{Period.StartTime % 60:D2} - {(Period.StartTime + Period.Duration) / 60:D2}:{(Period.StartTime + Period.Duration) % 60:D2}";
            set
            {
                var strs = value.Split(':', '.', ',', ';', '?', '"', '\'', ',');
                int result = -1;
                switch (strs.Length)
                {
                    case 0: return;
                    case 1: if (int.TryParse(strs[0], out int hour)) result = hour * 60; break;
                    default:
                            if (int.TryParse(strs[0], out hour)) result = hour * 60;
                            if (int.TryParse(strs[1], out int minute)) result = result > -1 ? result + minute : minute;
                        break;
                }
                if (result > -1 && result < 1440)
                    Period.StartTime = (uint)result;
            }
        }
        public string Duration
        {
            get
            {
                return $"{Period.Duration / 60:D2}:{Period.Duration % 60:D2}";
            }
            set
            {
                var strs = value.Split(':', '.', ',', ';', '?', '"', '\'', ',');
                int result = -1;
                switch (strs.Length)
                {
                    case 0: return;
                    case 1: if (int.TryParse(strs[0], out int hour)) result = hour * 60; break;
                    default:
                        if (int.TryParse(strs[0], out hour)) result = hour * 60;
                        if (int.TryParse(strs[1], out int minute)) result = result > -1 ? result + minute : minute;
                        break;
                }
                if (result > -1 && result < 1440)
                    Period.Duration = (uint)result;
            }
        }
        public string Information 
        {
            get
            {
                return string.Join(' ', Period.Actions.Select(a => $"{a.Value,3}%").ToArray());
            }
        }
        public Guid GetGuid()
        {
            return Period.Guid;
        }
    }
    public class ActionInfo : IGuidable
    {
        public Action Action { get; set; }
        public string Name {  get => Action.Name; set => Action.Name = value; }
        public string Duration
        {
            get => $"{Action.Value} {Action.UnitOfMeasure}";
            set
            {
                if (float.TryParse(value, out float result)) Action.Value = result;
            }
        }

        public Guid GetGuid()
        {
            return Action.Guid;
        }
    }
    public class BaseParam : BaseClass, ICloneable
    {
        #region Fields
        private string name;
        private string unitOfMeasure;
        private string description;
        private string reduction;
        #endregion
        #region Properties
        public string Name { get => name; set { name = value; OnPropertyChanged(nameof(Name)); } }
        public string UnitOfMeasure { get => unitOfMeasure; set { unitOfMeasure = value; OnPropertyChanged(nameof(UnitOfMeasure)); } }
        public string Description { get => description; set { description = value; OnPropertyChanged(nameof(Description)); } }
        public string Reduction { get => reduction; set { reduction = value; OnPropertyChanged(nameof(Reduction)); } }

        public object Clone()
        {
            return new BaseParam() { name = name, description = description, unitOfMeasure = unitOfMeasure, reduction = reduction };
        }
        #endregion
    }
    public class LightParam : BaseClass
    {
        private byte cH1;
        private byte cH2;
        private byte cH3;
        private byte cH4;
        public byte CH1 { get => cH1; set { cH1 = value; OnPropertyChanged(nameof(CH1)); } }
        public byte CH2 { get => cH2; set { cH2 = value; OnPropertyChanged(nameof(CH2)); } }
        public byte CH3 { get => cH3; set { cH3 = value; OnPropertyChanged(nameof(CH3)); } }
        public byte CH4 { get => cH4; set { cH4 = value; OnPropertyChanged(nameof(CH4)); } }
    }
    public class BaseClass : INotifyPropertyChanged
    {
        public readonly Guid Guid = Guid.NewGuid();
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Methods
        protected void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);
        protected void OnPropertyChanged(string propertyName) => OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        #endregion
    }
    public interface IGuidable
    {
        public Guid GetGuid();
    }
    public enum ActionsType
    {
        Watering,
        Lighting,
        Feeding,
        Blowing,
    }
}
