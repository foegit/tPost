using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tPost
{
    public class ListUBPanel
    {
        private List<UBPanel> _list;

        public int Count {
            get => _list.Count;
        }

        private EventHandler RemoveButtonHandler;

        public event EventHandler ListChange;

        public ListUBPanel()
        {
            _list = new List<UBPanel>();
            RemoveButtonHandler += (sender, args) =>
            {
               
                var ubPanelToRemove = sender as UBPanel;
                _list.Remove(ubPanelToRemove);
                //MessageBox.Show($"Delete! List count = {Count}");
                ListChange?.Invoke(this, EventArgs.Empty);

            };

        }
        public UBPanel this[ int index]
        {
            get { return _list[index]; }
        }

        public void Add(UBPanel panel)
        {
            _list.Add(panel);
            _list[_list.Count-1].DelButtonClick += RemoveButtonHandler;
            ListChange?.Invoke(this, EventArgs.Empty);
        }

        public void RemoveAt(int index)
        {
            if (index < _list.Count)
            {
                
                _list.RemoveAt(index);
                ListChange?.Invoke(this, EventArgs.Empty);
            }
           
        }

        

    }
}