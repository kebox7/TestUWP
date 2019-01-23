using System;
using TestUWP.ViewModels.Helpers;
using Windows.UI.Xaml;

namespace TestUWP.ViewModels {
    class MainPageViewModel : BindableBase {
        #region Закрытые поля
        private readonly DispatcherTimer timer = null;
        #endregion

        public MainPageViewModel() {
            this.timer = new DispatcherTimer {
                Interval = TimeSpan.FromSeconds(1)
            };
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        #region Закрытые методы
        private void Timer_Tick(object sender, object e) {
            DateTimeNow = DateTime.Now;
        }
        #endregion

        #region Свойства
        private DateTime dateTimeNow = default;
        public DateTime DateTimeNow {
            get => this.dateTimeNow;
            set => SetProperty(ref this.dateTimeNow, value);
        }
        #endregion
    }
}
