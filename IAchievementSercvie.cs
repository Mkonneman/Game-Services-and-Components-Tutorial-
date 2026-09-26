using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServicesAndComponentsExercise
{
    public interface IAchievementSercvie
    {
        public void UpdateAchievment(string achivment, uint progress);
    }
}
