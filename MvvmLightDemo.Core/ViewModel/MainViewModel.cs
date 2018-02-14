using System.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLightDemo.Core.Models;
using MvvmLightDemo.Core.Helpers;
using MvvmLightDemo.Core.Extensions;


namespace MvvmLightDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private List<Card> FootballCards;
        private RelayCommand buttonClicked;


        private int numberShuffles;
        public int NumberOfShuffles
        {
            get { return numberShuffles; }
            set
            {
                Set(() => NumberOfShuffles, ref numberShuffles, value, true);
                if (numberShuffles > 0) {
                    buttonClicked.RaiseCanExecuteChanged();
                }
            }
        }

        private string teamName;
        public string TeamName
        {
            get { return teamName; }
            set { Set(() => TeamName, ref teamName, value, true); }
        }

        private string stadiumName;
        public string StadiumName
        {
            get { return stadiumName; }
            set { Set(() => StadiumName, ref stadiumName, value, true); }
        }

        private double capacity;
        public double Capacity
        {
            get { return capacity; }
            set { Set(() => Capacity, ref capacity, value, true); }
        }

        private double longitude;
        public double Longitude
        {
            get { return longitude; }
            set { Set(() => Longitude, ref longitude, value, true); }
        }

        private double latitude;
        public double Latitude
        {
            get { return latitude; }
            set { Set(() => Latitude, ref latitude, value, true); }
        }

        public RelayCommand ButtonClicked
        {
            get
            {
                return buttonClicked ?? (buttonClicked = new RelayCommand(() => {
                    FootballCards = FootballCards.Shuffle(NumberOfShuffles);

                    var topCard = FootballCards.First();

                    TeamName = topCard.TeamName;
                    StadiumName = topCard.StadiumName;
                    Capacity = topCard.Capacity;
                    Longitude = topCard.Longitude;
                    Latitude = topCard.Latitude;
                }));
            }
        }


        public MainViewModel()
        {

            FootballCards = Teams.GenerateCards;
            NumberOfShuffles = 0;

            var firstTeam = FootballCards.First();
            TeamName = firstTeam.TeamName;
            StadiumName = firstTeam.StadiumName;
            Capacity = firstTeam.Capacity;
            Longitude = firstTeam.Longitude;
            Latitude = firstTeam.Latitude;
        }
    }
}