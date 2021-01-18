using PFE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PFE.Framework
{
    public class PFEUnitOfWork : UnitOfWork, IPFEUnitOfWork
    {
        //public ICategoryRepository CategoryRepository { get; set; }
        public PFEUnitOfWork( FrameworkContext frameworkContext //,ICategoryRepository categoryRepository
                                                                  )
            :base(frameworkContext)
        {
            //CategoryRepository = categoryRepository;
        }
    }
}
