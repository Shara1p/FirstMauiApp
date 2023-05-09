using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiApp
{
    internal partial class MainViewModel : ObservableObject
    {
        private List<Human> humanList = new List<Human>();

        [ObservableProperty]
        string firstName;
        [ObservableProperty]
        string secondName;
        [ObservableProperty]
        String birthDate;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        void TapOk()
        {
            IsBusy = true;

            humanList.Add(new Human(FirstName, SecondName, DateTime.Parse(BirthDate)));

            Console.WriteLine(humanList[0]);

            IsBusy = false;

        }

        [RelayCommand]
        void TapRefresh()
        {
            IsBusy = true;

            FirstName = "Иван";

            SecondName = "Иванов";

            BirthDate = "29/04/1999";

            IsBusy = false;
        }

        [RelayCommand]
        void TapDelete(Human human)
        {
            IsBusy = true;

            if (HumanList.Count > 0)
            {
                HumanList.Remove(human);
            }

            IsBusy = false;
        }

        [RelayCommand]
        void TapEdit(Human human)
        {
            IsBusy = true;

            for(int i = 0; i < HumanList.Count; i++)
            {
                if (HumanList[i].Equals(human))
                {
                    HumanList[i] = new Human(FirstName, SecondName, DateTime.Parse(BirthDate));
                }
            }

            IsBusy = false;
        }

    }
}
