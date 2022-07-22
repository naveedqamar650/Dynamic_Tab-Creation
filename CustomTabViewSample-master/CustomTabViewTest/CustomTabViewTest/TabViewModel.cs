using SliMvvm.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CustomTabViewTest
{
    public class TabViewModel : ObservableObject
    {
        private string _title;
        private string _content;
        private bool _isSelected;

        public TabViewModel(string title)
        {
            this.Title = title;
            this.Content = title;
        }

        public string Title { get => _title; set => Set(ref _title, value); }


        public string Content { get => _content; set => Set(ref _content, value); }

        public bool IsSelected { get => _isSelected; set =>Set(ref _isSelected, value); }
    }
}
