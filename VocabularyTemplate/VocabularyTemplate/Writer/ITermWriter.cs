﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VocabularyTemplate
{
    public interface ITermWriter : IDisposable
    {
        /// <summary>
        /// Start the object scope.
        /// </summary>
        void StartObjectScope();

        /// <summary>
        /// End the current object scope.
        /// </summary>
        void EndObjectScope();

        /// <summary>
        /// Start the array scope.
        /// </summary>
        void StartArrayScope();

        /// <summary>
        /// End the current array scope.
        /// </summary>
        void EndArrayScope();

        /// <summary>
        /// Write a property name to the current json object.
        /// </summary>
        /// <param name="name">The name to write.</param>
        void WritePropertyName(string name);

        /// <summary>
        /// Write a string value to the current json scope.
        /// </summary>
        /// <param name="value">The value to write.</param>
        void WriteValue(string value);

        void Flush();
    }
}
