using System.Collections.Generic;
namespace HashMap;

public interface IRole
{
    string GetRoleName();
    bool HasPermission(string permission);
}


public class AdminRole : IRole
{
    private List<string> permissions = new List<string> { "read", "write", "delete" };

    public string GetRoleName() => "Admin";

    public bool HasPermission(string permission)
    {
        return permissions.Contains(permission);
    }
}

public class UserRole : IRole
{
    private List<string> permissions = new List<string> { "read" };

    public string GetRoleName() => "User";

    public bool HasPermission(string permission)
    {
        return permissions.Contains(permission);
    }
}

public class ManagerRole : IRole
{
    private List<string> permissions = new List<string> { "read", "write" };

    public string GetRoleName() => "Manager";

    public bool HasPermission(string permission)
    {
        return permissions.Contains(permission);
    }
}


public class AuthSystem
{
    private Dictionary<string, IRole> userRoles = new Dictionary<string, IRole>();

    public void AssignRole(string username, IRole role)
    {
        userRoles[username] = role;
        Console.WriteLine($"Role {role.GetRoleName()} assigned to {username}.");
    }

    public bool CheckAccess(string username, string permission)
    {
        if (userRoles.TryGetValue(username, out IRole role))
        {
            return role.HasPermission(permission);
        }
        Console.WriteLine($"{username} has no assigned role.");
        return false;
    }
}
