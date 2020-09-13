using MMEX.Common.Data.DataAccess;
using MMEX.Common.Data.Models;
using System;

namespace MMEX.Common.Data.Business.Managers
{
    public class OptionLocalMngr
    {
        private readonly OptionLocalRepository _repository;

        private string _DbPath = null;

        public OptionLocalMngr(string DbPath)
        {
            _DbPath = DbPath;
            _repository = new OptionLocalRepository(_DbPath);
        }

        private bool? _ShowBeginForm;

        public bool ShowBeginForm
        {
            get
            {
                if (_ShowBeginForm == null)
                {
                    //bool? status = _repository.GetOptionLocalByName("SHOWBEGINAPP")
                    //if (_repository.GetOptionLocalByName("SHOWBEGINAPP"))
                }
                    _ShowBeginForm = Convert.ToBoolean(_repository.GetByName("SHOWBEGINAPP").Value);
                return _ShowBeginForm.Value;
            }
            set
            {
                _ShowBeginForm = value;
                OptionLocal opt = new OptionLocal
                {
                    Name = "SHOWBEGINAPP",
                    Value = value.ToString()
                };
                _repository.SaveOptionLocal(opt);
            }
        }

    }
}
