using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChipType_Sample
{
    public class ViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Language> languages;

        private ObservableCollection<Language> selectedItems;

        private ObservableCollection<Loactions> locations;

        private ObservableCollection<Qualification> qualifications;

        private ObservableCollection<LanguagesSpoke> languagesSpoke;


        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Language> Languages
        {
            get
            {
                return languages;
            }
            set
            {
                languages = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Languages"));
            }
        }
        
        public ObservableCollection<Language> SelectedItems
        {
            get
            {
                return selectedItems;
            }
            set
            {
                selectedItems = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("SelectedItems"));
            }
        }
       
        public ObservableCollection<Loactions> Locations
        {
            get
            {
                return locations;
            }
            set
            {
                locations = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Locations"));
            }
        }

        public ObservableCollection<Qualification> Qualifications
        {
            get
            {
                return qualifications;
            }
            set
            {
                qualifications = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QUalifications"));
            }
        }

        public ObservableCollection<LanguagesSpoke> LanguagesSpoke
        {
            get
            {
                return languagesSpoke;
            }
            set
            {
                languagesSpoke = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LanguagesSpoke"));
            }
        }

        public ViewModel()
        {
            Languages = new ObservableCollection<Language>();
            Languages.Add(new Language() { Name = "C#" });
            Languages.Add(new Language() { Name = "HTML" });
            Languages.Add(new Language() { Name = "Java" });
            Languages.Add(new Language() { Name = "JS" });

            selectedItems = new ObservableCollection<Language>() { Languages[0], Languages[1] };

            Locations = new ObservableCollection<Loactions>();
            Locations.Add(new Loactions() { Place="US"});
            Locations.Add(new Loactions() { Place = "UK" });
            Locations.Add(new Loactions() { Place = "India" });
            Locations.Add(new Loactions() { Place = "China" });
            Locations.Add(new Loactions() { Place = "Australia" });

            Qualifications = new ObservableCollection<Qualification>();
            Qualifications.Add(new Qualification() {graduate="UG" });
            Qualifications.Add(new Qualification() { graduate = "PG" });

            LanguagesSpoke = new ObservableCollection<LanguagesSpoke>();
            LanguagesSpoke.Add(new LanguagesSpoke() {LangaugeSpoke="English" });
            LanguagesSpoke.Add(new LanguagesSpoke() { LangaugeSpoke = "Japanese" });
            LanguagesSpoke.Add(new LanguagesSpoke() { LangaugeSpoke = "Chinese" });
            LanguagesSpoke.Add(new LanguagesSpoke() { LangaugeSpoke = "French" });
            LanguagesSpoke.Add(new LanguagesSpoke() { LangaugeSpoke = "Russian" });
            LanguagesSpoke.Add(new LanguagesSpoke() { LangaugeSpoke = "Spanish" });
        }
    }
  
}
