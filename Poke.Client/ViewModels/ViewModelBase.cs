using System.Threading.Tasks;

namespace Poke.Client.ViewModels
{
    public class ViewModelBase : NotificationEnabledObject
    {
        public ViewModelBase() { }

        public virtual Task Initialize(object parameter) => Task.CompletedTask;
        public virtual Task Initialize() => Initialize(null);
    }
}
