using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
     public static class ProjectProcessor
    {
        public static int CreateProject(int projectId, string projectTitle, DateTime projectStartDate)
        {
            ProjectModel data = new ProjectModel
            {
                ProjectId = projectId,
                ProjectTitle = projectTitle,
                ProjectStartDate = projectStartDate


            };

            string sql = @"insert into dbo.Project (ProjectId, ProjectTitle, ProjectStartDate) values (@ProjectId, @ProjectTitle, @ProjectStartDate);";
            return SqlDataAccess.SaveData(sql, data);

        }

        public static List<ProjectModel> LoadProjects()
        {
            string sql = @"select ProjectId, ProjectTitle, ProjectStartDate from dbo.Project;";

            return SqlDataAccess.LoadData<ProjectModel>(sql);

        }
    }
}
