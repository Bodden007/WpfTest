using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Threading;

namespace WpfTest
{
    public class Class1 : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private int data;
        private bool one = true;
        private bool two = false;
        private bool three = false;
        
        public int Data1
        {
            get { return data; }
            set { data = value; }
        }
        public int Data2
        {
            get { return data; }
            set { data = value; }
        }
        public int Data3
        {
            get { return data; }
            set { data = value; }
        }

        public void Foo()
        {
            for (int i = 0; i <= 50; i++)
            {
                if  (one)
                {
                    Data1 = i;
                    one = false;
                    two = true;
                    OnPropertyChanged(nameof(Data1));
                }else if (two)
                {
                    Data2 = i;
                    two = false;
                    three = true;
                    OnPropertyChanged(nameof(Data2));
                }else if (three)
                {
                    Data3 = i;
                    three = false;
                    one = true;
                    OnPropertyChanged(nameof(Data3));
                }
                
                
                Thread.Sleep(500);
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = " ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
