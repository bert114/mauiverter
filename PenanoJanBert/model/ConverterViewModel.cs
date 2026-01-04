using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenanoJanBert.model
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        private string? option;

        public string? Option
        {
            get => option;
            set
            {
                if (option != value)
                {
                    option = value;
                    OnPropertyChanged(nameof(Option));
                }
            }
        }

        public ConverterViewModel(string? option = null)
        {
            Option = option;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string QuantityName { get; set; }
        public ObservableCollection<string> FromMeasures { get; set; }
        public ObservableCollection<string> ToMeasures { get; set; }
        public string CurrentFromMeasure { get; set; }
        public string CurrentToMeasure { get; set; }
        public double FromValue { get; set; } = 1;
        public double ToValue { get; set; }

    }
}
