﻿using System.Collections.Generic;

namespace SalesApi.Core.Abstractions.DomainModels.Tree
{
    public class TreeEntity<T> : EntityBase, ITreeEntity<T> where T : TreeEntity<T>
    {
        public int? ParentId { get; set; }
        public string AncestorIds { get; set; }
        public bool IsAbstract { get; set; }
        public int Level => AncestorIds?.Split('-').Length ?? 0;
        public T Parent { get; set; }
        public ICollection<T> Children { get; set; }
    }
}
