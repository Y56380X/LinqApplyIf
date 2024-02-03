// Copyright Y56380X https://github.com/Y56380X/LinqApplyIf.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApplyIf
{
    /// <summary>
    /// Providing extenstion methods to apply transformations conditionally on enumerations.
    /// </summary>
    public static class ApplyIfExtensions
    {
        /// <summary>
        /// Apply a given transformation to a enumerable if condition applies.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <typeparam name="T">Enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IEnumerable<T> ApplyIf<T>(
            this IEnumerable<T> source,
            Func<bool> condition,
            Func<IEnumerable<T>, IEnumerable<T>> ifBinding) =>
            condition() ? ifBinding(source) : source;

        /// <summary>
        /// Apply a given if-transformation to a enumerable if condition applies, if not else-transformation is applied.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <param name="elseBinding">Transformation which applies if condition is false</param>
        /// <typeparam name="TSource">Input enumerable item type</typeparam>
        /// <typeparam name="TTarget">Output enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IEnumerable<TTarget> ApplyIfElse<TSource, TTarget>(
            this IEnumerable<TSource> source,
            Func<bool> condition,
            Func<IEnumerable<TSource>, IEnumerable<TTarget>> ifBinding,
            Func<IEnumerable<TSource>, IEnumerable<TTarget>> elseBinding) =>
            condition() ? ifBinding(source) : elseBinding(source);
        
        /// <summary>
        /// Apply a given transformation to a enumerable if condition applies.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <typeparam name="T">Enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IQueryable<T> ApplyIf<T>(
            this IQueryable<T> source,
            Func<bool> condition,
            Func<IQueryable<T>, IQueryable<T>> ifBinding) =>
            condition() ? ifBinding(source) : source;

        /// <summary>
        /// Apply a given if-transformation to a enumerable if condition applies, if not else-transformation is applied.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <param name="elseBinding">Transformation which applies if condition is false</param>
        /// <typeparam name="TSource">Input enumerable item type</typeparam>
        /// <typeparam name="TTarget">Output enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IQueryable<TTarget> ApplyIfElse<TSource, TTarget>(
            this IQueryable<TSource> source,
            Func<bool> condition,
            Func<IQueryable<TSource>, IQueryable<TTarget>> ifBinding,
            Func<IQueryable<TSource>, IQueryable<TTarget>> elseBinding) =>
            condition() ? ifBinding(source) : elseBinding(source);
        
        /// <summary>
        /// Apply a given transformation to a enumerable if condition applies.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Evaluated condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <typeparam name="T">Enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IEnumerable<T> ApplyIf<T>(
            this IEnumerable<T> source,
            bool condition,
            Func<IEnumerable<T>, IEnumerable<T>> ifBinding) =>
            condition ? ifBinding(source) : source;

        /// <summary>
        /// Apply a given if-transformation to a enumerable if condition applies, if not else-transformation is applied.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Evaluated condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <param name="elseBinding">Transformation which applies if condition is false</param>
        /// <typeparam name="TSource">Input enumerable item type</typeparam>
        /// <typeparam name="TTarget">Output enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IEnumerable<TTarget> ApplyIfElse<TSource, TTarget>(
            this IEnumerable<TSource> source,
            bool condition,
            Func<IEnumerable<TSource>, IEnumerable<TTarget>> ifBinding,
            Func<IEnumerable<TSource>, IEnumerable<TTarget>> elseBinding) =>
            condition ? ifBinding(source) : elseBinding(source);
        
        /// <summary>
        /// Apply a given transformation to a enumerable if condition applies.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Evaluated condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <typeparam name="T">Enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IQueryable<T> ApplyIf<T>(
            this IQueryable<T> source,
            bool condition,
            Func<IQueryable<T>, IQueryable<T>> ifBinding) =>
            condition ? ifBinding(source) : source;

        /// <summary>
        /// Apply a given if-transformation to a enumerable if condition applies, if not else-transformation is applied.
        /// </summary>
        /// <param name="source">Source enumerable</param>
        /// <param name="condition">Evaluated condition</param>
        /// <param name="ifBinding">Transformation which applies if condition is true</param>
        /// <param name="elseBinding">Transformation which applies if condition is false</param>
        /// <typeparam name="TSource">Input enumerable item type</typeparam>
        /// <typeparam name="TTarget">Output enumerable item type</typeparam>
        /// <returns>Enumerable with conditionally applied transformation.</returns>
        public static IQueryable<TTarget> ApplyIfElse<TSource, TTarget>(
            this IQueryable<TSource> source,
            bool condition,
            Func<IQueryable<TSource>, IQueryable<TTarget>> ifBinding,
            Func<IQueryable<TSource>, IQueryable<TTarget>> elseBinding) =>
            condition ? ifBinding(source) : elseBinding(source);
    }
}
