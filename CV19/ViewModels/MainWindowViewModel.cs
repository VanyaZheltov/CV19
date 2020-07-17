using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        #region заголовок окна
        private string _Title = "test";
        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
            
        }
        #endregion
    }
}
