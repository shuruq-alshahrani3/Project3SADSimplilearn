using ProjectSAD3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.ViewModel
{
    public class ViewModelIndex
    {

        public string Item { get; set; }
      
        public IEnumerable<Computer> computer { get; set; }

    }
}
