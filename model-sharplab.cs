using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;

[assembly: FSharpInterfaceDataVersion(2, 0, 0)]
[assembly: AssemblyVersion("0.0.0.0")]

[CompilationMapping(SourceConstructFlags.Module)]
public static class @_
{
    [Serializable]
    [CompilationMapping(SourceConstructFlags.RecordType)]
    public sealed class Part : IEquatable<Part>, IStructuralEquatable, IComparable<Part>, IComparable, IStructuralComparable
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal string PartNumber@;

        [CompilationMapping(SourceConstructFlags.Field, 0)]
        public string PartNumber
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return PartNumber@;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(Part))]
        public Part(string partNumber)
        {
            PartNumber@ = partNumber;
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<Part, string>, Unit, string, string, Part>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(Part obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    IComparer genericComparer = LanguagePrimitives.GenericComparer;
                    return string.CompareOrdinal(PartNumber@, obj.PartNumber@);
                }
                return 1;
            }
            if (obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj)
        {
            return CompareTo((Part)obj);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj, IComparer comp)
        {
            Part part = (Part)obj;
            Part part2 = part;
            if (this != null)
            {
                if ((Part)obj != null)
                {
                    return string.CompareOrdinal(PartNumber@, part2.PartNumber@);
                }
                return 1;
            }
            if ((Part)obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                string partNumber@ = PartNumber@;
                string text = partNumber@;
                return -1640531527 + (((text != null) ? text.GetHashCode() : 0) + ((num << 6) + (num >> 2)));
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                Part part = obj as Part;
                if (part != null)
                {
                    Part part2 = part;
                    return string.Equals(PartNumber@, part2.PartNumber@);
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(Part obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    return string.Equals(PartNumber@, obj.PartNumber@);
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            Part part = obj as Part;
            if (part != null)
            {
                return Equals(part);
            }
            return false;
        }
    }


    [Serializable]
    [CompilationMapping(SourceConstructFlags.RecordType)]
    public sealed class PartEntry : IEquatable<PartEntry>, IStructuralEquatable, IComparable<PartEntry>, IComparable, IStructuralComparable
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal Part Part@;

        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal int Quantity@;

        [CompilationMapping(SourceConstructFlags.Field, 0)]
        public Part Part
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return Part@;
            }
        }

        [CompilationMapping(SourceConstructFlags.Field, 1)]
        public int Quantity
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return Quantity@;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(PartEntry))]
        public PartEntry(Part part, int quantity)
        {
            Part@ = part;
            Quantity@ = quantity;
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<PartEntry, string>, Unit, string, string, PartEntry>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(PartEntry obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    IComparer genericComparer = LanguagePrimitives.GenericComparer;
                    Part part@ = Part@;
                    Part part@2 = obj.Part@;
                    int num = part@.CompareTo(part@2, genericComparer);
                    if (num < 0)
                    {
                        return num;
                    }
                    if (num > 0)
                    {
                        return num;
                    }
                    IComparer genericComparer2 = LanguagePrimitives.GenericComparer;
                    int quantity@ = Quantity@;
                    int quantity@2 = obj.Quantity@;
                    return ((quantity@ > quantity@2) ? 1 : 0) - ((quantity@ < quantity@2) ? 1 : 0);
                }
                return 1;
            }
            if (obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj)
        {
            return CompareTo((PartEntry)obj);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj, IComparer comp)
        {
            PartEntry partEntry = (PartEntry)obj;
            PartEntry partEntry2 = partEntry;
            if (this != null)
            {
                if ((PartEntry)obj != null)
                {
                    Part part@ = Part@;
                    Part part@2 = partEntry2.Part@;
                    int num = part@.CompareTo(part@2, comp);
                    if (num < 0)
                    {
                        return num;
                    }
                    if (num > 0)
                    {
                        return num;
                    }
                    int quantity@ = Quantity@;
                    int quantity@2 = partEntry2.Quantity@;
                    return ((quantity@ > quantity@2) ? 1 : 0) - ((quantity@ < quantity@2) ? 1 : 0);
                }
                return 1;
            }
            if ((PartEntry)obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                num = -1640531527 + (Quantity@ + ((num << 6) + (num >> 2)));
                return -1640531527 + (Part@.GetHashCode(comp) + ((num << 6) + (num >> 2)));
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                PartEntry partEntry = obj as PartEntry;
                if (partEntry != null)
                {
                    PartEntry partEntry2 = partEntry;
                    Part part@ = Part@;
                    Part part@2 = partEntry2.Part@;
                    if (part@.Equals(part@2, comp))
                    {
                        return Quantity@ == partEntry2.Quantity@;
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(PartEntry obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    if (Part@.Equals(obj.Part@))
                    {
                        return Quantity@ == obj.Quantity@;
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            PartEntry partEntry = obj as PartEntry;
            if (partEntry != null)
            {
                return Equals(partEntry);
            }
            return false;
        }
    }


    [Serializable]
    [CompilationMapping(SourceConstructFlags.RecordType)]
    public sealed class KitSet : IEquatable<KitSet>, IStructuralEquatable, IComparable<KitSet>, IComparable, IStructuralComparable
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal string KitId@;

        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal FSharpSet<PartEntry> LineItem@;

        [CompilationMapping(SourceConstructFlags.Field, 0)]
        public string KitId
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return KitId@;
            }
        }

        [CompilationMapping(SourceConstructFlags.Field, 1)]
        public FSharpSet<PartEntry> LineItem
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return LineItem@;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(KitSet))]
        public KitSet(string kitId, FSharpSet<PartEntry> lineItem)
        {
            KitId@ = kitId;
            LineItem@ = lineItem;
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<KitSet, string>, Unit, string, string, KitSet>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(KitSet obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    IComparer genericComparer = LanguagePrimitives.GenericComparer;
                    int num = string.CompareOrdinal(KitId@, obj.KitId@);
                    if (num < 0)
                    {
                        return num;
                    }
                    if (num > 0)
                    {
                        return num;
                    }
                    return LanguagePrimitives.HashCompare.GenericComparisonWithComparerIntrinsic(LanguagePrimitives.GenericComparer, LineItem@, obj.LineItem@);
                }
                return 1;
            }
            if (obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj)
        {
            return CompareTo((KitSet)obj);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj, IComparer comp)
        {
            KitSet kitSet = (KitSet)obj;
            KitSet kitSet2 = kitSet;
            if (this != null)
            {
                if ((KitSet)obj != null)
                {
                    int num = string.CompareOrdinal(KitId@, kitSet2.KitId@);
                    if (num < 0)
                    {
                        return num;
                    }
                    if (num > 0)
                    {
                        return num;
                    }
                    return LanguagePrimitives.HashCompare.GenericComparisonWithComparerIntrinsic(comp, LineItem@, kitSet2.LineItem@);
                }
                return 1;
            }
            if ((KitSet)obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                num = -1640531527 + (LanguagePrimitives.HashCompare.GenericHashWithComparerIntrinsic(comp, LineItem@) + ((num << 6) + (num >> 2)));
                string kitId@ = KitId@;
                string text = kitId@;
                return -1640531527 + (((text != null) ? text.GetHashCode() : 0) + ((num << 6) + (num >> 2)));
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                KitSet kitSet = obj as KitSet;
                if (kitSet != null)
                {
                    KitSet kitSet2 = kitSet;
                    if (string.Equals(KitId@, kitSet2.KitId@))
                    {
                        return LanguagePrimitives.HashCompare.GenericEqualityWithComparerIntrinsic(comp, LineItem@, kitSet2.LineItem@);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(KitSet obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    if (string.Equals(KitId@, obj.KitId@))
                    {
                        return LanguagePrimitives.HashCompare.GenericEqualityERIntrinsic(LineItem@, obj.LineItem@);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            KitSet kitSet = obj as KitSet;
            if (kitSet != null)
            {
                return Equals(kitSet);
            }
            return false;
        }
    }


    [Serializable]
    [CompilationMapping(SourceConstructFlags.RecordType)]
    public sealed class StaticKit : IEquatable<StaticKit>, IStructuralEquatable, IComparable<StaticKit>, IComparable, IStructuralComparable
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal string KitId@;

        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal FSharpSet<PartEntry> LineItem@;

        [CompilationMapping(SourceConstructFlags.Field, 0)]
        public string KitId
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return KitId@;
            }
        }

        [CompilationMapping(SourceConstructFlags.Field, 1)]
        public FSharpSet<PartEntry> LineItem
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return LineItem@;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(StaticKit))]
        public StaticKit(string kitId, FSharpSet<PartEntry> lineItem)
        {
            KitId@ = kitId;
            LineItem@ = lineItem;
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<StaticKit, string>, Unit, string, string, StaticKit>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(StaticKit obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    IComparer genericComparer = LanguagePrimitives.GenericComparer;
                    int num = string.CompareOrdinal(KitId@, obj.KitId@);
                    if (num < 0)
                    {
                        return num;
                    }
                    if (num > 0)
                    {
                        return num;
                    }
                    return LanguagePrimitives.HashCompare.GenericComparisonWithComparerIntrinsic(LanguagePrimitives.GenericComparer, LineItem@, obj.LineItem@);
                }
                return 1;
            }
            if (obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj)
        {
            return CompareTo((StaticKit)obj);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj, IComparer comp)
        {
            StaticKit staticKit = (StaticKit)obj;
            StaticKit staticKit2 = staticKit;
            if (this != null)
            {
                if ((StaticKit)obj != null)
                {
                    int num = string.CompareOrdinal(KitId@, staticKit2.KitId@);
                    if (num < 0)
                    {
                        return num;
                    }
                    if (num > 0)
                    {
                        return num;
                    }
                    return LanguagePrimitives.HashCompare.GenericComparisonWithComparerIntrinsic(comp, LineItem@, staticKit2.LineItem@);
                }
                return 1;
            }
            if ((StaticKit)obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                num = -1640531527 + (LanguagePrimitives.HashCompare.GenericHashWithComparerIntrinsic(comp, LineItem@) + ((num << 6) + (num >> 2)));
                string kitId@ = KitId@;
                string text = kitId@;
                return -1640531527 + (((text != null) ? text.GetHashCode() : 0) + ((num << 6) + (num >> 2)));
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                StaticKit staticKit = obj as StaticKit;
                if (staticKit != null)
                {
                    StaticKit staticKit2 = staticKit;
                    if (string.Equals(KitId@, staticKit2.KitId@))
                    {
                        return LanguagePrimitives.HashCompare.GenericEqualityWithComparerIntrinsic(comp, LineItem@, staticKit2.LineItem@);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(StaticKit obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    if (string.Equals(KitId@, obj.KitId@))
                    {
                        return LanguagePrimitives.HashCompare.GenericEqualityERIntrinsic(LineItem@, obj.LineItem@);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            StaticKit staticKit = obj as StaticKit;
            if (staticKit != null)
            {
                return Equals(staticKit);
            }
            return false;
        }
    }


    [Serializable]
    [CompilationMapping(SourceConstructFlags.RecordType)]
    public sealed class EditableKit : IEquatable<EditableKit>, IStructuralEquatable
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal string KitId@;

        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal List<PartEntry> Part@;

        [CompilationMapping(SourceConstructFlags.Field, 0)]
        public string KitId
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return KitId@;
            }
        }

        [CompilationMapping(SourceConstructFlags.Field, 1)]
        public List<PartEntry> Part
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return Part@;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(EditableKit))]
        public EditableKit(string kitId, List<PartEntry> part)
        {
            KitId@ = kitId;
            Part@ = part;
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<EditableKit, string>, Unit, string, string, EditableKit>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                num = -1640531527 + (LanguagePrimitives.HashCompare.GenericHashWithComparerIntrinsic(comp, Part@) + ((num << 6) + (num >> 2)));
                string kitId@ = KitId@;
                string text = kitId@;
                return -1640531527 + (((text != null) ? text.GetHashCode() : 0) + ((num << 6) + (num >> 2)));
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                EditableKit editableKit = obj as EditableKit;
                if (editableKit != null)
                {
                    EditableKit editableKit2 = editableKit;
                    if (string.Equals(KitId@, editableKit2.KitId@))
                    {
                        return LanguagePrimitives.HashCompare.GenericEqualityWithComparerIntrinsic(comp, Part@, editableKit2.Part@);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(EditableKit obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    if (string.Equals(KitId@, obj.KitId@))
                    {
                        return LanguagePrimitives.HashCompare.GenericEqualityERIntrinsic(Part@, obj.Part@);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            EditableKit editableKit = obj as EditableKit;
            if (editableKit != null)
            {
                return Equals(editableKit);
            }
            return false;
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
    [DebuggerDisplay("{__DebugDisplay(),nq}")]
    [CompilationMapping(SourceConstructFlags.SumType)]
    public abstract class Kit : IEquatable<Kit>, IStructuralEquatable
    {
        public static class Tags
        {
            public const int AsBuilt = 0;

            public const int SpeedKit = 1;
        }


        [Serializable]
        [SpecialName]
        [DebuggerTypeProxy(typeof(AsBuilt@DebugTypeProxy))]
        [DebuggerDisplay("{__DebugDisplay(),nq}")]
        public class AsBuilt : Kit
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal readonly StaticKit item;

            [CompilationMapping(SourceConstructFlags.Field, 0, 0)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            public StaticKit Item
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return item;
                }
            }

            [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(Kit))]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal AsBuilt(StaticKit item)
            {
                this.item = item;
            }
        }


        [Serializable]
        [SpecialName]
        [DebuggerTypeProxy(typeof(SpeedKit@DebugTypeProxy))]
        [DebuggerDisplay("{__DebugDisplay(),nq}")]
        public class SpeedKit : Kit
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal readonly EditableKit item;

            [CompilationMapping(SourceConstructFlags.Field, 1, 0)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            public EditableKit Item
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return item;
                }
            }

            [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(Kit))]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal SpeedKit(EditableKit item)
            {
                this.item = item;
            }
        }


        [SpecialName]
        internal class AsBuilt@DebugTypeProxy
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal AsBuilt _obj;

            [CompilationMapping(SourceConstructFlags.Field, 0, 0)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            public StaticKit Item
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return _obj.item;
                }
            }

            [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(Kit))]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            public AsBuilt@DebugTypeProxy(AsBuilt obj)
            {
                _obj = obj;
            }
        }


        [SpecialName]
        internal class SpeedKit@DebugTypeProxy
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal SpeedKit _obj;

            [CompilationMapping(SourceConstructFlags.Field, 1, 0)]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            public EditableKit Item
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return _obj.item;
                }
            }

            [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(Kit))]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            public SpeedKit@DebugTypeProxy(SpeedKit obj)
            {
                _obj = obj;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Tag
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return (this is SpeedKit) ? 1 : 0;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        public bool IsAsBuilt
        {
            [DebuggerNonUserCode]
            get
            {
                return this is AsBuilt;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        public bool IsSpeedKit
        {
            [DebuggerNonUserCode]
            get
            {
                return this is SpeedKit;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(Kit))]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal Kit()
        {
        }

        [CompilationMapping(SourceConstructFlags.UnionCase, 0)]
        public static Kit NewAsBuilt(StaticKit item)
        {
            return new AsBuilt(item);
        }

        [CompilationMapping(SourceConstructFlags.UnionCase, 1)]
        public static Kit NewSpeedKit(EditableKit item)
        {
            return new SpeedKit(item);
        }

        [SpecialName]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal object __DebugDisplay()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<Kit, string>, Unit, string, string, string>("%+0.8A")).Invoke(this);
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<Kit, string>, Unit, string, string, Kit>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                if (this is AsBuilt)
                {
                    AsBuilt asBuilt = (AsBuilt)this;
                    num = 0;
                    return -1640531527 + (asBuilt.item.GetHashCode(comp) + ((num << 6) + (num >> 2)));
                }
                SpeedKit speedKit = (SpeedKit)this;
                num = 1;
                return -1640531527 + (speedKit.item.GetHashCode(comp) + ((num << 6) + (num >> 2)));
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                Kit kit = obj as Kit;
                if (kit != null)
                {
                    Kit kit2 = kit;
                    int num = ((this is SpeedKit) ? 1 : 0);
                    Kit kit3 = kit2;
                    int num2 = ((kit3 is SpeedKit) ? 1 : 0);
                    if (num == num2)
                    {
                        if (this is AsBuilt)
                        {
                            AsBuilt asBuilt = (AsBuilt)this;
                            AsBuilt asBuilt2 = (AsBuilt)kit2;
                            StaticKit item = asBuilt.item;
                            StaticKit item2 = asBuilt2.item;
                            return item.Equals(item2, comp);
                        }
                        SpeedKit speedKit = (SpeedKit)this;
                        SpeedKit speedKit2 = (SpeedKit)kit2;
                        EditableKit item3 = speedKit.item;
                        EditableKit item4 = speedKit2.item;
                        return item3.Equals(item4, comp);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(Kit obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    int num = ((this is SpeedKit) ? 1 : 0);
                    int num2 = ((obj is SpeedKit) ? 1 : 0);
                    if (num == num2)
                    {
                        if (this is AsBuilt)
                        {
                            AsBuilt asBuilt = (AsBuilt)this;
                            AsBuilt asBuilt2 = (AsBuilt)obj;
                            return asBuilt.item.Equals(asBuilt2.item);
                        }
                        SpeedKit speedKit = (SpeedKit)this;
                        SpeedKit speedKit2 = (SpeedKit)obj;
                        return speedKit.item.Equals(speedKit2.item);
                    }
                    return false;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            Kit kit = obj as Kit;
            if (kit != null)
            {
                return Equals(kit);
            }
            return false;
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
    [DebuggerDisplay("{__DebugDisplay(),nq}")]
    [CompilationMapping(SourceConstructFlags.SumType)]
    public sealed class PartLine : IEquatable<PartLine>, IStructuralEquatable, IComparable<PartLine>, IComparable, IStructuralComparable
    {
        public static class Tags
        {
            public const int Part = 0;

            public const int Kit = 1;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal readonly int _tag;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal static readonly PartLine _unique_Part = new PartLine(0);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal static readonly PartLine _unique_Kit = new PartLine(1);

        [CompilerGenerated]
        [DebuggerNonUserCode]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Tag
        {
            [CompilerGenerated]
            [DebuggerNonUserCode]
            get
            {
                return _tag;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static PartLine Part
        {
            [CompilationMapping(SourceConstructFlags.UnionCase, 0)]
            get
            {
                return _unique_Part;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static PartLine Kit
        {
            [CompilationMapping(SourceConstructFlags.UnionCase, 1)]
            get
            {
                return _unique_Kit;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        public bool IsPart
        {
            [DebuggerNonUserCode]
            get
            {
                return Tag == 0;
            }
        }

        [CompilerGenerated]
        [DebuggerNonUserCode]
        public bool IsKit
        {
            [DebuggerNonUserCode]
            get
            {
                return Tag == 1;
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(PartLine))]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal PartLine(int _tag)
        {
            this._tag = _tag;
        }

        [SpecialName]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal object __DebugDisplay()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<PartLine, string>, Unit, string, string, string>("%+0.8A")).Invoke(this);
        }

        [CompilerGenerated]
        public override string ToString()
        {
            return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<PartLine, string>, Unit, string, string, PartLine>("%+A")).Invoke(this);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(PartLine obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    int tag = _tag;
                    int tag2 = obj._tag;
                    if (tag == tag2)
                    {
                        return 0;
                    }
                    return tag - tag2;
                }
                return 1;
            }
            if (obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj)
        {
            return CompareTo((PartLine)obj);
        }

        [CompilerGenerated]
        public sealed override int CompareTo(object obj, IComparer comp)
        {
            PartLine partLine = (PartLine)obj;
            if (this != null)
            {
                if ((PartLine)obj != null)
                {
                    int tag = _tag;
                    int tag2 = partLine._tag;
                    if (tag == tag2)
                    {
                        return 0;
                    }
                    return tag - tag2;
                }
                return 1;
            }
            if ((PartLine)obj != null)
            {
                return -1;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode(IEqualityComparer comp)
        {
            if (this != null)
            {
                int num = 0;
                return _tag;
            }
            return 0;
        }

        [CompilerGenerated]
        public sealed override int GetHashCode()
        {
            return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj, IEqualityComparer comp)
        {
            if (this != null)
            {
                PartLine partLine = obj as PartLine;
                if (partLine != null)
                {
                    PartLine partLine2 = partLine;
                    int tag = _tag;
                    int tag2 = partLine2._tag;
                    return tag == tag2;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(PartLine obj)
        {
            if (this != null)
            {
                if (obj != null)
                {
                    int tag = _tag;
                    int tag2 = obj._tag;
                    return tag == tag2;
                }
                return false;
            }
            return obj == null;
        }

        [CompilerGenerated]
        public sealed override bool Equals(object obj)
        {
            PartLine partLine = obj as PartLine;
            if (partLine != null)
            {
                return Equals(partLine);
            }
            return false;
        }
    }
}

namespace <StartupCode$_>
{
    internal static class $_
    {
        public static void main@()
        {
        }
    }
}
