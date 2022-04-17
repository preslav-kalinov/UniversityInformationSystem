using MinimalMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MinimalMVVM.ViewModel
{
    class ToSmallSymbols : ObservableObject
    {
        protected readonly TextConverter _textConverter = new TextConverter(s => s.ToLower());
        private string _someText;
        private readonly ObservableCollection<string> _history = (ObservableCollection<string>)Presenter.History;

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        private void ConvertText()
        {
            AddToHistory(_textConverter.ConvertText(SomeText));
            SomeText = String.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
    }
}
