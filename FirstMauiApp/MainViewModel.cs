using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMauiApp.Model;
using System.Collections.ObjectModel;

namespace FirstMauiApp
{
    internal partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<Human> HumanList { get; } = new();

        [ObservableProperty]
        string firstName;
        [ObservableProperty]
        string secondName;
        [ObservableProperty]
        string birthDate;


        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        void TapOk()
        {
            IsBusy = true;

            HumanList.Add(new Human(FirstName, SecondName, DateTime.Parse(BirthDate)));

            Console.WriteLine(HumanList[0]);

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
