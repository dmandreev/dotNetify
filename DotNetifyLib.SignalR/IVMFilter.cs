﻿/* 
Copyright 2017 Dicky Suryadi

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 */

using System;

namespace DotNetify
{
   /// <summary>
   /// Marker interface for view model filter pipelines.
   /// </summary>
   public interface IVMFilter
   {
   }

   /// <summary>
   /// Provides filter pipelines for view models that's associated with a class attribute.
   /// </summary>
   public interface IVMFilter<TAttribute> : IVMFilter where TAttribute : Attribute
   {
      void Invoke(TAttribute attribute, VMContext context);
   }
}
