using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace lab1
{
    class Save:ICommand
    {
        public bool CanExecute(Object parameter)
        {
            return true;
        }
        public void Execute(Object parameter)
        {
            var vm = parameter as ViewModel;
            if (vm == null) throw new ArgumentNullException("Модель представления не можеть быть null");
            if((vm.cash)&&(vm.selectedChange==0)) throw new ArgumentNullException("Выберите сумму для размена");
            if((vm.card)&&((String.IsNullOrWhiteSpace(vm.cardHolder))||(vm.numberOfCard==0)||(vm.selectedValidThroughMonth==0)||(vm.selectedValidThroughYear==0)||(vm.CVV==0))) throw new ArgumentNullException("Не хватает данных о карте");
        }
        public event EventHandler CanExecuteChanged;
    }
}
