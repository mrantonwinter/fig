using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fig.ViewModels
{
    public class Result : BaseVM
    {
        bool? _Success = null;
        public bool? Success
        {
            get { return _Success; }
            set
            {
                _Success = value;
                Changed();
            }
        }

        string _Message = "";
        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                Changed();
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////

        public Result Init(bool? success, string message)
        {
            Success = success;
            Message = message;
            return this;
        }

    }
}
