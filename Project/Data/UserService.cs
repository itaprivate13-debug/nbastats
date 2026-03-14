namespace Project.Data
{
    public class UserService
    {
        public List<Player> GetPlayer(string name)
        {
            string sql = "SELECT * FROM Players WHERE Name = {};";

            return DbHelper.RunSelect<Player>(sql, name);
        }

        public List<Player> GetFeaturedPlayers()
        {
            string sql = $@"SELECT Players.Id, Players.TeamId, Players.Name, Players.PPG, Players.APG, Players.RPG, Players.ImageUrl, Teams.Name AS TeamName
                           FROM Players
                           JOIN Teams ON Players.TeamId = Teams.Id
                           WHERE Players.Name IN ('Deni Avdija', 'LeBron James', 'Stephen Curry', 'Giannis Antetokounmpo', 'Luka Dončić');";

            return DbHelper.RunSelect<Player>(sql);
        }

        public List<Teams> GetAllTeams()
        {
            string sql = "SELECT * FROM Teams;";

            return DbHelper.RunSelect<Teams>(sql);
        }
    }
}
