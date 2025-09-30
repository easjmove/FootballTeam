using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamLib
{
    public class FootballRepo
    {
        private int _nextId = 1;
        private List<FootballTeam> teams;

        public FootballRepo()
        {
            teams = new List<FootballTeam>
            {
                new FootballTeam { Id = _nextId++, Name = "Manchester United", League = "Premier League" },
                new FootballTeam { Id = _nextId++, Name = "Real Madrid", League = "La Liga" },
                new FootballTeam { Id = _nextId++, Name = "Bayern Munich", League = "Bundesliga" }
            };
        }

        public List<FootballTeam> GetAllTeams()
        {
            return new List<FootballTeam>(teams);
        }

        public FootballTeam? GetTeamById(int id)
        {
            return teams.FirstOrDefault(t => t.Id == id);
        }

        public FootballTeam AddTeam(FootballTeam team)
        {
            team.Id = _nextId++;
            teams.Add(team);
            return team;
        }

        public FootballTeam? UpdateTeam(int id, FootballTeam updatedTeam)
        {
            FootballTeam? existingTeam = GetTeamById(id);
            if (existingTeam != null)
            {
                existingTeam.Name = updatedTeam.Name;
                existingTeam.League = updatedTeam.League;
            }
            return existingTeam;
        }

        public FootballTeam? DeleteTeam(int id)
        {
            FootballTeam? team = GetTeamById(id);
            if (team != null)
            {
                teams.Remove(team);
            }
            return team;
        }
    }
}
