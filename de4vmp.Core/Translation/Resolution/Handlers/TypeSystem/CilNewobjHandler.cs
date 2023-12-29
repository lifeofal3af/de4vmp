﻿using AsmResolver.DotNet.Code.Cil;
using AsmResolver.PE.DotNet.Cil;
using de4vmp.Core.Architecture;

namespace de4vmp.Core.Translation.Resolution.Handlers.TypeSystem;

public class CilNewobjHandler : TypeSystemHandlerBase {
    private readonly IEnumerable<CilCode> _signature = new List<CilCode> {
        CilCode.Ldarg,
        CilCode.Ldarg,
        CilCode.Call,
        CilCode.Callvirt,
        CilCode.Call,
        CilCode.Stloc,
        CilCode.Ldarg,
        CilCode.Ldloc,
        CilCode.Call,
        CilCode.Stloc,
        CilCode.Ldloc,
        CilCode.Brfalse,
        CilCode.Ldarg,
        CilCode.Ldloc,
        CilCode.Call,
        CilCode.Ret
    };

    public override VmpCode Translates => VmpCode.CilNewobjCode;

    public override bool Resolve(CilInstructionCollection instructions) {
        return instructions.AreSignatureEqual(_signature);
    }
}