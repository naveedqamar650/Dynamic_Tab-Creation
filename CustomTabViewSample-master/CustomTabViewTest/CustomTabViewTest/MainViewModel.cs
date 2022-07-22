using SliMvvm.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomTabViewTest
{
public class MainViewModel : ObservableObject
{
    private TabViewModel _currentTabVm;
        int count = 1;
  
    public MainViewModel()
    {

        this.TabVms = new ObservableCollection<TabViewModel>();
        this.TabVms.Add(new TabViewModel("TAB" + count));
        TapCommand = new Command(OnTapped);
        this.CurrentTabVm = this.TabVms.FirstOrDefault();
    }


        void OnTapped (Object s)
        {
            count++;
            this.TabVms.Add(new TabViewModel("TAB" + count));
        }

        private ICommand _tapCommand;

        public ICommand TapCommand
        {
            get { return _tapCommand; }
            set { _tapCommand = value; }
        }


        public ObservableCollection<TabViewModel> TabVms { get; set; } 

    public TabViewModel CurrentTabVm 
    { 
        get => _currentTabVm;
        set
        {
            Set(ref _currentTabVm, value);
            SetSelection();
        }
    }

    private void SetSelection()
    {
        this.TabVms.ForEach(vm => vm.IsSelected = false);
        this.CurrentTabVm.IsSelected = true;
    }
}
}
