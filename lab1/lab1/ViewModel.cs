using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
namespace lab1
{
    class ViewModel:INotifyPropertyChanged
    {
        public Double price { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public Visibility cashVisibility { get; set; }
        public Visibility cardVisibility { get; set; }
        private bool _cash = true;
        public bool cash
        {
            get { return _cash; }
            set
            {
                _cash = value;
                DoPropertyChanged("cash");
                if (value) _card = false;
                DoPropertyChanged("card");
                cardVisibility = Visibility.Hidden;
                cashVisibility = Visibility.Visible;
                DoPropertyChanged("cardVisibility");
                DoPropertyChanged("cashVisibility");
            }
        }
        public List<int> change { get; set; }
        public int selectedChange { get; set; }
        public bool _card;
        public bool card
        {
            get { return _card; }
            set
            {
                _card = value; ;
                DoPropertyChanged("card");
                if (value) _cash = false;
                DoPropertyChanged("cash");
                cardVisibility = Visibility.Visible;
                cashVisibility = Visibility.Hidden;
                DoPropertyChanged("cardVisibility");
                DoPropertyChanged("cashVisibility");
            }
         

        }
       

        public Int64 numberOfCard { get; set; }
        public string cardHolder { get; set; }
        public List<int> validThroughMonth { get; set; }
        public int selectedValidThroughMonth { get; set; }
        public List<int> validThroughYear { get; set; }
        public int selectedValidThroughYear { get; set; }
        public int CVV { get; set; }

        public ICommand Save { get; set; }

        public ViewModel()
        {
            CVV = 123;
            numberOfCard = 1000000000000000;

            Save = new Save();
            cardVisibility = Visibility.Hidden;
            change = new List<int>()
            {
                100,
                500,
                1000,
                5000
            };
            validThroughMonth= new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };
            validThroughYear = new List<int>
            {
                18,
                19,
                20,
                21,
                22,
                23,
                24,
                25
            };
        }

    }
}
