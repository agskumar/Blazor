using ServerManagement.Models;

public static class ServersRepository
{
    private static List<Server> servers = new List<Server>()
        {
            new Server {  Id = 1, Name = "Server 1", City = "Tokyo" },
            new Server {  Id = 2, Name = "Server 2", City = "Mumbai" },
            new Server {  Id = 3, Name = "Server 3", City = "Paris" },
            new Server {  Id = 4, Name = "Server 4", City = "Sydney" },
            new Server {  Id = 5, Name = "Server 5", City = "London" },
            new Server {  Id = 6, Name = "Server 6", City = "Montreal" },
            new Server {  Id = 7, Name = "Server 7", City = "Montreal" },
            new Server {  Id = 8, Name = "Server 8", City = "Ottawa" },
            new Server {  Id = 9, Name = "Server 9", City = "Ottawa" },
            new Server {  Id = 10, Name = "Server 10", City = "Calgary" },
            new Server {  Id = 11, Name = "Server 11", City = "Calgary" },
            new Server {  Id = 12, Name = "Server 12", City = "Halifax" },
            new Server {  Id = 13, Name = "Server 13", City = "Halifax" },
        };

    public static void AddServer(Server server)
    {
        var maxId = servers.Max(s => s.Id);
        server.Id = maxId + 1;
        servers.Add(server);
    }

    public static List<Server> GetServers() => servers;

    public static List<Server> GetServersByCity(string cityName)
    {
        return servers.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static Server? GetServerById(int id)
    {
        var server = servers.FirstOrDefault(s => s.Id == id);
        if (server != null)
        {
            return new Server
            {
                Id = server.Id,
                Name = server.Name,
                City = server.City,
                IsOnline = server.IsOnline
            };
        }

        return null;
    }

    public static void UpdateServer(int serverId, Server server)
    {
        if (serverId != server.Id) return;

        var serverToUpdate = servers.FirstOrDefault(s => s.Id == serverId);
        if (serverToUpdate != null)
        {
            serverToUpdate.IsOnline = server.IsOnline;
            serverToUpdate.Name = server.Name;
            serverToUpdate.City = server.City;
        }
    }

    public static void DeleteServer(int serverId)
    {
        var server = servers.FirstOrDefault(s => s.Id == serverId);
        if (server != null)
        {
            servers.Remove(server);
        }
    }

    public static List<Server> SearchServers(string serverFilter)
    {
        return servers.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}