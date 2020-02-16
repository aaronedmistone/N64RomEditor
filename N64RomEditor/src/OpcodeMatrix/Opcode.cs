﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N64RomEditor.src.OpcodeMatrix
{
    public class Opcode
    {
        private static List<Opcode> Opcodes { get; set; } = new List<Opcode>();
        public Opcode(string name, List<BitField> bitFields, List<ParameterBitField> appearance)
        {
            // Check that all items within both BitField arrays are valid
            int invalidCount = appearance.Count(x => bitFields.Count(y => y.GetType() == x.GetType()) == 0);
            if (invalidCount > 0)
            {
                throw new Exception(
                        $"All items within the appearance list must also be within the bitFields list.\r\n" +
                        $"Failed [{invalidCount}/{appearance.Count}]");
            }
            // Matrix.Fit(); todo
            Opcodes.Add(this);
        }
        public static void InstantiateOpcodes()
        {
            //MIPS3Instructions.ArithmeticInstructions.InstantiateOpcodes();
            //MIPS3Instructions.ExceptionInstructions.InstantiateOpcodes();
            //MIPS3Instructions.FloatingPointUnitComparisonInstructions.InstantiateOpcodes();
            //MIPS3Instructions.FloatingPointUnitInstructions.InstantiateOpcodes();
            //MIPS3Instructions.JumpAndBranchInstructions.InstantiateOpcodes();
            //MIPS3Instructions.LoadAndStoreInstructions.InstantiateOpcodes();
            //MIPS3Instructions.SpecialInstructions.InstantiateOpcodes();
            //MIPS3Instructions.SystemControlProcessorInstructions.InstantiateOpcodes();
            List<Opcode> opcodes = Opc
        }
    }
}
