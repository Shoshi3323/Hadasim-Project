using Microsoft.EntityFrameworkCore;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaManagementSystem.Dal
{
    public class Repository
    {
        CoronaContext context;
        public CoronaDetailsTable(CoronaContext context)
        {
            this.context = context;
        
        public void Create(CoronaDetailsTable objToCreate)
        {
            context.CoronaDetailsTable.Add(objToCreate);
            context.SaveChanges();
        }
        //שליפת תאריכי חיסונים
        public List<CoronaDetailsTable> GetAll()
        {
            return context.CoronaDetailsTable.Include(c => c.IdVaccination).Include(c => c.DateVaccination1).Include(c => c.DateVaccination2).Include(c => c.DateVaccination3).Include(c => c.DateVaccination34).ToList();
        }

    }
    
}

//שגיאה בהרצה
//Scaffold-DbContext 'Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\This_User\Documents\CoronaManagementSystem\CoronaManagementSystem.Dal\CoronaDB.mdf;Integrated Security=True;Connect Timeout=30' Microsoft.EntityFrameworkCore.SqlServer –Context CoronaContext -OutputDir Models -Force
