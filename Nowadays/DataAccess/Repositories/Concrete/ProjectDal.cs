using DataAccess.Repositories.Abstract;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class ProjectDal : BaseRepo<Project>, IProjectDal
    {
    }
}
