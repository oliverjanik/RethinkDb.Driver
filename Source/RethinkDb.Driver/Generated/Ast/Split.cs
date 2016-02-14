












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Split : ReqlExpr {

    
    
    
/// <summary>
/// <para>Splits a string into substrings.  Splits on whitespace when called
/// with no arguments.  When called with a separator, splits on that
/// separator.  When called with a separator and a maximum number of
/// splits, splits on that separator at most <code>max_splits</code> times.  (Can be
/// called with <code>null</code> as the separator if you want to split on whitespace
/// while still specifying <code>max_splits</code>.)</para>
/// <para>Mimics the behavior of Python's <code>string.split</code> in edge cases, except
/// for splitting on the empty string, which instead produces an array of
/// single-character strings.</para>
/// </summary>
/// <example><para>Example: Split on whitespace.</para>
/// <code>r.expr("foo  bar bax").split().run(conn, callback)
/// </code></example>
        public Split (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Splits a string into substrings.  Splits on whitespace when called
/// with no arguments.  When called with a separator, splits on that
/// separator.  When called with a separator and a maximum number of
/// splits, splits on that separator at most <code>max_splits</code> times.  (Can be
/// called with <code>null</code> as the separator if you want to split on whitespace
/// while still specifying <code>max_splits</code>.)</para>
/// <para>Mimics the behavior of Python's <code>string.split</code> in edge cases, except
/// for splitting on the empty string, which instead produces an array of
/// single-character strings.</para>
/// </summary>
/// <example><para>Example: Split on whitespace.</para>
/// <code>r.expr("foo  bar bax").split().run(conn, callback)
/// </code></example>
        public Split (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Splits a string into substrings.  Splits on whitespace when called
/// with no arguments.  When called with a separator, splits on that
/// separator.  When called with a separator and a maximum number of
/// splits, splits on that separator at most <code>max_splits</code> times.  (Can be
/// called with <code>null</code> as the separator if you want to split on whitespace
/// while still specifying <code>max_splits</code>.)</para>
/// <para>Mimics the behavior of Python's <code>string.split</code> in edge cases, except
/// for splitting on the empty string, which instead produces an array of
/// single-character strings.</para>
/// </summary>
/// <example><para>Example: Split on whitespace.</para>
/// <code>r.expr("foo  bar bax").split().run(conn, callback)
/// </code></example>
        public Split (Arguments args, OptArgs optargs)
         : base(TermType.SPLIT, args, optargs) {
        }


    



    


    

    


    
    }
}
