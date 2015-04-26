﻿//-----------------------------------------------------------------------
// <copyright file="BlockHeader.cs">
// Copyright © Ladislau Molnar. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BitcoinBlockchain.Data
{
    using System;

    /// <summary>
    /// Contains information about a Bitcoin block header.
    /// For more information see: https://en.bitcoin.it/wiki/Block_hashing_algorithm
    /// </summary>
    public class BlockHeader
    {
        /// <summary>
        /// Gets the block version number.
        /// </summary>
        public UInt32 BlockVersion { get; internal set; }

        /// <summary>
        /// Gets the 256-bit hash of this block header.
        /// This ByteArray instance contains the hash in reverse order from what is the 
        /// normal result of hashing. This is to be consistent with sites like
        /// blockchain.info and blockexporer that display hashes in 'big endian' format.
        /// </summary>
        public ByteArray BlockHash { get; internal set; }

        /// <summary>
        /// Gets the 256-bit hash of the previous active block header.
        /// This ByteArray instance contains the hash in reverse order from what is the 
        /// normal result of hashing. This is to be consistent with sites like
        /// blockchain.info and blockexporer that display hashes in 'big endian' format.
        /// Note that orphan blocks will be skipped. In other words a block following an
        /// orphan block will not have PreviousBlockHash indicating the orphan block 
        /// but the previous active block.
        /// </summary>
        public ByteArray PreviousBlockHash { get; internal set; }

        /// <summary>
        /// Gets the 256-bit hash based on all transactions in the block.
        /// This ByteArray instance contains the hash in reverse order from what is the 
        /// normal result of hashing. This is to be consistent with sites like
        /// blockchain.info and blockexporer that display hashes in 'big endian' format.
        /// </summary>
        public ByteArray MerkleRootHash { get; internal set; }

        /// <summary>
        /// Gets the block creation timestamp as seconds since 1970-01-01T00:00 UTC.
        /// </summary>
        public UInt32 BlockTimestampUnix { get; internal set; }

        /// <summary>
        /// Gets the block creation timestamp.
        /// </summary>
        public DateTime BlockTimestamp { get; internal set; }

        /// <summary>
        /// Gets the block target difficulty.
        /// </summary>
        public UInt32 BlockTargetDifficulty { get; internal set; }

        /// <summary>
        /// Gets the block nonce. 
        /// See https://en.bitcoin.it/wiki/Nonce.
        /// </summary>
        public uint BlockNonce { get; internal set; }
    }
}
