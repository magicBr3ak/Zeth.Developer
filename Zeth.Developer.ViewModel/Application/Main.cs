using System.ObjectModel;
using System.Windows.Input;

namespace Zeth.Developer.ViewModel.Application
{
    public class Main : ObservableObject<Main>
    {
        #region Properties
        public Command New { get; private set; }
        public Command Open { get; private set; }
        public Command Save { get; private set; }
        #endregion
    }
}
