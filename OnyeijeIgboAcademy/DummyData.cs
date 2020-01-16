using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy
{
    public static class DummyData
    {
        public static void SeedDifficultyLevel(this ModelBuilder builder)
        {
            builder.Entity<DifficultyLevels>().HasData(
                new DifficultyLevels[]
                {
                    new DifficultyLevels {DifficultyLevelId = 1, DifficultLevel = "Beginner"},
                    new DifficultyLevels {DifficultyLevelId = 2, DifficultLevel = "Intermediate"},
                    new DifficultyLevels {DifficultyLevelId = 3, DifficultLevel = "Advanced"},
                   
                }
                );
        }
    }
}
