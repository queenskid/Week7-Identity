using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models.Interfaces
{
    public interface ITodoService
    {
        List<ToDo> GetTopToDo();
    }
}
