// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FederationDescriptionBase.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Federation.Domain
{
    /// <summary>
    /// Base class describing the federation.
    /// </summary>
    public class FederationDescriptionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FederationDescriptionBase"/> class.
        /// </summary>
        /// <param name="name">Name of the federation.</param>
        public FederationDescriptionBase(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name of the federation.
        /// </summary>
        public string Name { get; private set; }
    }

    /// <summary>
    /// Specific implementation of <see cref="FederationDescriptionBase" /> for reactors.
    /// </summary>
    public class ReactorFederationDescription : FederationDescriptionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactorFederationDescription"/> class.
        /// </summary>
        /// <param name="name">Name of the federation.</param>
        public ReactorFederationDescription(string name)
            : base(name)
        {
        }
    }
}
