﻿using System.Runtime.Serialization;

namespace Ocelli.OpenClickBank.Builder.Data;

public enum RoleAccount
{
    [EnumMember(Value = "VENDOR")] VENDOR,
    [EnumMember(Value = "AFFILIATE")] AFFILIATE
}