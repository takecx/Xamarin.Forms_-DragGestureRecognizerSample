using System;
using Prism.Commands;
using Prism.Mvvm;

namespace DragGestureRecognizerSample
{
    public class MainPageViewModel : BindableBase
    {
        public DelegateCommand DragCommand { get; private set; }
        private bool CanDrag()
        {
            return true;
        }

        public MainPageViewModel()
        {
            DragCommand = new DelegateCommand(Drag, CanDrag);
        }

        private void Drag()
        {
            Console.WriteLine("Dragging");
        }

    }
}
