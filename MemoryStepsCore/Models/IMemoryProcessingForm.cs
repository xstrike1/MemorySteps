using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStepsCore.Models
{
    public interface IMemoryProcessingForm : IMemoryForm
    {
        bool CancelHasBeenRequested { get; set; }
    }
}
