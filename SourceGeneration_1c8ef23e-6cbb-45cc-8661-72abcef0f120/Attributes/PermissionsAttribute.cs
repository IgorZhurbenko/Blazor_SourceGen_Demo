using System;

namespace SourceGeneration.Permissions
{
    public class PermissionsAttribute : Attribute
    {
        public readonly string[] Actions;
        public readonly uint[] ActionIds;
        public PermissionsAttribute(params string[] actions)
        {
            Actions = actions;
        }

        public PermissionsAttribute(params uint[] actionPermissionsIDs)
        {
            ActionIds = actionPermissionsIDs;
        }

    }

    public class PermissionsClassAttribute : Attribute
    {
    }
}