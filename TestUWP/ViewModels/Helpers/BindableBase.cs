﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestUWP.ViewModels.Helpers {
    internal abstract class BindableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null) {
            if (Equals(storage, value))
                return;

            storage = value;
            OnPropertyChanged(propertyName);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
