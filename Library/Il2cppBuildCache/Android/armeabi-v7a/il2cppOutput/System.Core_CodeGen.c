#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Union(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000F System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::UnionIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000010 System.Boolean System.Linq.Enumerable::SequenceEqual(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 System.Boolean System.Linq.Enumerable::SequenceEqual(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000012 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000013 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000014 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000015 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000016 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000017 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000018 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000019 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001A System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001B System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001C System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x0000001D System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001E System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x0000001F TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000020 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000021 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000022 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000023 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000024 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000025 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000026 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000027 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000028 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000029 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000002A System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000002B System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x0000002C System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x0000002D System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002F System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000030 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000031 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000032 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000033 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000034 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000035 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000036 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000037 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000038 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000039 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003A System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x0000003B System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x0000003C System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x0000003D System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003E System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003F System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000040 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000041 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000042 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000043 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000044 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000045 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000046 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000047 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000048 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000049 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000004A System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000004B System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x0000004C TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x0000004D System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x0000004E System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x0000004F System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x00000050 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x00000051 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x00000052 TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000053 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000054 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000055 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000056 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x00000057 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000058 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x00000059 System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x0000005A System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x0000005B TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x0000005C System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000005D System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000005E System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x0000005F System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000060 System.Void System.Linq.Enumerable/<UnionIterator>d__71`1::.ctor(System.Int32)
// 0x00000061 System.Void System.Linq.Enumerable/<UnionIterator>d__71`1::System.IDisposable.Dispose()
// 0x00000062 System.Boolean System.Linq.Enumerable/<UnionIterator>d__71`1::MoveNext()
// 0x00000063 System.Void System.Linq.Enumerable/<UnionIterator>d__71`1::<>m__Finally1()
// 0x00000064 System.Void System.Linq.Enumerable/<UnionIterator>d__71`1::<>m__Finally2()
// 0x00000065 TSource System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000066 System.Void System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.IEnumerator.Reset()
// 0x00000067 System.Object System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.IEnumerator.get_Current()
// 0x00000068 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000069 System.Collections.IEnumerator System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000006A System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x0000006B System.Boolean System.Linq.Set`1::Add(TElement)
// 0x0000006C System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x0000006D System.Void System.Linq.Set`1::Resize()
// 0x0000006E System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x0000006F System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000070 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000071 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000072 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000073 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000074 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x00000075 System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x00000076 TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x00000077 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x00000078 System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x00000079 System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000007A System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000007B System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x0000007C System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x0000007D System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x0000007E System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x0000007F System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000080 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000081 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000082 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000083 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000084 TElement[] System.Linq.Buffer`1::ToArray()
// 0x00000085 System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000086 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000087 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000088 System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x00000089 System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x0000008A System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x0000008B System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x0000008C System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x0000008D System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x0000008E System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x0000008F System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000090 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000091 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000092 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000093 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000094 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x00000095 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x00000096 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x00000097 System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x00000098 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x00000099 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x0000009A System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x0000009B System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x0000009C System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x0000009D System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x0000009E System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x0000009F T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x000000A0 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x000000A1 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[161] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[161] = 
{
	3626,
	3626,
	3764,
	3764,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[52] = 
{
	{ 0x02000004, { 81, 4 } },
	{ 0x02000005, { 85, 9 } },
	{ 0x02000006, { 96, 7 } },
	{ 0x02000007, { 105, 10 } },
	{ 0x02000008, { 117, 11 } },
	{ 0x02000009, { 131, 9 } },
	{ 0x0200000A, { 143, 12 } },
	{ 0x0200000B, { 158, 1 } },
	{ 0x0200000C, { 159, 2 } },
	{ 0x0200000D, { 161, 12 } },
	{ 0x0200000E, { 173, 11 } },
	{ 0x0200000F, { 184, 12 } },
	{ 0x02000011, { 196, 8 } },
	{ 0x02000013, { 204, 3 } },
	{ 0x02000014, { 207, 5 } },
	{ 0x02000015, { 212, 7 } },
	{ 0x02000016, { 219, 3 } },
	{ 0x02000017, { 222, 7 } },
	{ 0x02000018, { 229, 4 } },
	{ 0x02000019, { 233, 21 } },
	{ 0x0200001B, { 254, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 1 } },
	{ 0x0600000A, { 31, 2 } },
	{ 0x0600000B, { 33, 2 } },
	{ 0x0600000C, { 35, 1 } },
	{ 0x0600000D, { 36, 2 } },
	{ 0x0600000E, { 38, 1 } },
	{ 0x0600000F, { 39, 2 } },
	{ 0x06000010, { 41, 1 } },
	{ 0x06000011, { 42, 5 } },
	{ 0x06000012, { 47, 3 } },
	{ 0x06000013, { 50, 2 } },
	{ 0x06000014, { 52, 4 } },
	{ 0x06000015, { 56, 3 } },
	{ 0x06000016, { 59, 3 } },
	{ 0x06000017, { 62, 3 } },
	{ 0x06000018, { 65, 1 } },
	{ 0x06000019, { 66, 3 } },
	{ 0x0600001A, { 69, 2 } },
	{ 0x0600001B, { 71, 3 } },
	{ 0x0600001C, { 74, 2 } },
	{ 0x0600001D, { 76, 5 } },
	{ 0x0600002D, { 94, 2 } },
	{ 0x06000032, { 103, 2 } },
	{ 0x06000037, { 115, 2 } },
	{ 0x0600003D, { 128, 3 } },
	{ 0x06000042, { 140, 3 } },
	{ 0x06000047, { 155, 3 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[256] = 
{
	{ (Il2CppRGCTXDataType)2, 1995 },
	{ (Il2CppRGCTXDataType)3, 6251 },
	{ (Il2CppRGCTXDataType)2, 3303 },
	{ (Il2CppRGCTXDataType)2, 2864 },
	{ (Il2CppRGCTXDataType)3, 12780 },
	{ (Il2CppRGCTXDataType)2, 2099 },
	{ (Il2CppRGCTXDataType)2, 2871 },
	{ (Il2CppRGCTXDataType)3, 12819 },
	{ (Il2CppRGCTXDataType)2, 2866 },
	{ (Il2CppRGCTXDataType)3, 12787 },
	{ (Il2CppRGCTXDataType)2, 1996 },
	{ (Il2CppRGCTXDataType)3, 6252 },
	{ (Il2CppRGCTXDataType)2, 3319 },
	{ (Il2CppRGCTXDataType)2, 2873 },
	{ (Il2CppRGCTXDataType)3, 12826 },
	{ (Il2CppRGCTXDataType)2, 2124 },
	{ (Il2CppRGCTXDataType)2, 2881 },
	{ (Il2CppRGCTXDataType)3, 12894 },
	{ (Il2CppRGCTXDataType)2, 2877 },
	{ (Il2CppRGCTXDataType)3, 12857 },
	{ (Il2CppRGCTXDataType)2, 771 },
	{ (Il2CppRGCTXDataType)3, 159 },
	{ (Il2CppRGCTXDataType)3, 160 },
	{ (Il2CppRGCTXDataType)2, 1362 },
	{ (Il2CppRGCTXDataType)3, 4806 },
	{ (Il2CppRGCTXDataType)2, 772 },
	{ (Il2CppRGCTXDataType)3, 171 },
	{ (Il2CppRGCTXDataType)3, 172 },
	{ (Il2CppRGCTXDataType)2, 1371 },
	{ (Il2CppRGCTXDataType)3, 4810 },
	{ (Il2CppRGCTXDataType)3, 14940 },
	{ (Il2CppRGCTXDataType)2, 781 },
	{ (Il2CppRGCTXDataType)3, 225 },
	{ (Il2CppRGCTXDataType)2, 2550 },
	{ (Il2CppRGCTXDataType)3, 10239 },
	{ (Il2CppRGCTXDataType)3, 14916 },
	{ (Il2CppRGCTXDataType)2, 777 },
	{ (Il2CppRGCTXDataType)3, 197 },
	{ (Il2CppRGCTXDataType)3, 14960 },
	{ (Il2CppRGCTXDataType)2, 784 },
	{ (Il2CppRGCTXDataType)3, 254 },
	{ (Il2CppRGCTXDataType)3, 14944 },
	{ (Il2CppRGCTXDataType)3, 4195 },
	{ (Il2CppRGCTXDataType)2, 1244 },
	{ (Il2CppRGCTXDataType)2, 1580 },
	{ (Il2CppRGCTXDataType)2, 1674 },
	{ (Il2CppRGCTXDataType)2, 1744 },
	{ (Il2CppRGCTXDataType)2, 999 },
	{ (Il2CppRGCTXDataType)3, 1147 },
	{ (Il2CppRGCTXDataType)3, 1148 },
	{ (Il2CppRGCTXDataType)2, 2100 },
	{ (Il2CppRGCTXDataType)3, 6663 },
	{ (Il2CppRGCTXDataType)2, 1932 },
	{ (Il2CppRGCTXDataType)2, 1490 },
	{ (Il2CppRGCTXDataType)2, 1590 },
	{ (Il2CppRGCTXDataType)2, 1677 },
	{ (Il2CppRGCTXDataType)2, 1591 },
	{ (Il2CppRGCTXDataType)2, 1678 },
	{ (Il2CppRGCTXDataType)3, 4808 },
	{ (Il2CppRGCTXDataType)2, 1592 },
	{ (Il2CppRGCTXDataType)2, 1679 },
	{ (Il2CppRGCTXDataType)3, 4809 },
	{ (Il2CppRGCTXDataType)2, 1931 },
	{ (Il2CppRGCTXDataType)2, 1589 },
	{ (Il2CppRGCTXDataType)2, 1676 },
	{ (Il2CppRGCTXDataType)2, 1575 },
	{ (Il2CppRGCTXDataType)2, 1576 },
	{ (Il2CppRGCTXDataType)2, 1672 },
	{ (Il2CppRGCTXDataType)3, 4805 },
	{ (Il2CppRGCTXDataType)2, 1489 },
	{ (Il2CppRGCTXDataType)2, 1587 },
	{ (Il2CppRGCTXDataType)2, 1588 },
	{ (Il2CppRGCTXDataType)2, 1675 },
	{ (Il2CppRGCTXDataType)3, 4807 },
	{ (Il2CppRGCTXDataType)2, 1488 },
	{ (Il2CppRGCTXDataType)3, 14903 },
	{ (Il2CppRGCTXDataType)3, 4194 },
	{ (Il2CppRGCTXDataType)2, 1243 },
	{ (Il2CppRGCTXDataType)2, 1578 },
	{ (Il2CppRGCTXDataType)2, 1673 },
	{ (Il2CppRGCTXDataType)2, 1743 },
	{ (Il2CppRGCTXDataType)3, 6253 },
	{ (Il2CppRGCTXDataType)3, 6255 },
	{ (Il2CppRGCTXDataType)2, 510 },
	{ (Il2CppRGCTXDataType)3, 6254 },
	{ (Il2CppRGCTXDataType)3, 6263 },
	{ (Il2CppRGCTXDataType)2, 1999 },
	{ (Il2CppRGCTXDataType)2, 2867 },
	{ (Il2CppRGCTXDataType)3, 12788 },
	{ (Il2CppRGCTXDataType)3, 6264 },
	{ (Il2CppRGCTXDataType)2, 1636 },
	{ (Il2CppRGCTXDataType)2, 1704 },
	{ (Il2CppRGCTXDataType)3, 4817 },
	{ (Il2CppRGCTXDataType)3, 14888 },
	{ (Il2CppRGCTXDataType)2, 2878 },
	{ (Il2CppRGCTXDataType)3, 12858 },
	{ (Il2CppRGCTXDataType)3, 6256 },
	{ (Il2CppRGCTXDataType)2, 1998 },
	{ (Il2CppRGCTXDataType)2, 2865 },
	{ (Il2CppRGCTXDataType)3, 12781 },
	{ (Il2CppRGCTXDataType)3, 4816 },
	{ (Il2CppRGCTXDataType)3, 6257 },
	{ (Il2CppRGCTXDataType)3, 14887 },
	{ (Il2CppRGCTXDataType)2, 2874 },
	{ (Il2CppRGCTXDataType)3, 12827 },
	{ (Il2CppRGCTXDataType)3, 6270 },
	{ (Il2CppRGCTXDataType)2, 2000 },
	{ (Il2CppRGCTXDataType)2, 2872 },
	{ (Il2CppRGCTXDataType)3, 12820 },
	{ (Il2CppRGCTXDataType)3, 6729 },
	{ (Il2CppRGCTXDataType)3, 3391 },
	{ (Il2CppRGCTXDataType)3, 4818 },
	{ (Il2CppRGCTXDataType)3, 3390 },
	{ (Il2CppRGCTXDataType)3, 6271 },
	{ (Il2CppRGCTXDataType)3, 14889 },
	{ (Il2CppRGCTXDataType)2, 2882 },
	{ (Il2CppRGCTXDataType)3, 12895 },
	{ (Il2CppRGCTXDataType)3, 6284 },
	{ (Il2CppRGCTXDataType)2, 2002 },
	{ (Il2CppRGCTXDataType)2, 2880 },
	{ (Il2CppRGCTXDataType)3, 12860 },
	{ (Il2CppRGCTXDataType)3, 6285 },
	{ (Il2CppRGCTXDataType)2, 1639 },
	{ (Il2CppRGCTXDataType)2, 1707 },
	{ (Il2CppRGCTXDataType)3, 4822 },
	{ (Il2CppRGCTXDataType)3, 4821 },
	{ (Il2CppRGCTXDataType)2, 2869 },
	{ (Il2CppRGCTXDataType)3, 12790 },
	{ (Il2CppRGCTXDataType)3, 14896 },
	{ (Il2CppRGCTXDataType)2, 2879 },
	{ (Il2CppRGCTXDataType)3, 12859 },
	{ (Il2CppRGCTXDataType)3, 6277 },
	{ (Il2CppRGCTXDataType)2, 2001 },
	{ (Il2CppRGCTXDataType)2, 2876 },
	{ (Il2CppRGCTXDataType)3, 12829 },
	{ (Il2CppRGCTXDataType)3, 4820 },
	{ (Il2CppRGCTXDataType)3, 4819 },
	{ (Il2CppRGCTXDataType)3, 6278 },
	{ (Il2CppRGCTXDataType)2, 2868 },
	{ (Il2CppRGCTXDataType)3, 12789 },
	{ (Il2CppRGCTXDataType)3, 14895 },
	{ (Il2CppRGCTXDataType)2, 2875 },
	{ (Il2CppRGCTXDataType)3, 12828 },
	{ (Il2CppRGCTXDataType)3, 6291 },
	{ (Il2CppRGCTXDataType)2, 2003 },
	{ (Il2CppRGCTXDataType)2, 2884 },
	{ (Il2CppRGCTXDataType)3, 12897 },
	{ (Il2CppRGCTXDataType)3, 6730 },
	{ (Il2CppRGCTXDataType)3, 3393 },
	{ (Il2CppRGCTXDataType)3, 4824 },
	{ (Il2CppRGCTXDataType)3, 4823 },
	{ (Il2CppRGCTXDataType)3, 3392 },
	{ (Il2CppRGCTXDataType)3, 6292 },
	{ (Il2CppRGCTXDataType)2, 2870 },
	{ (Il2CppRGCTXDataType)3, 12791 },
	{ (Il2CppRGCTXDataType)3, 14897 },
	{ (Il2CppRGCTXDataType)2, 2883 },
	{ (Il2CppRGCTXDataType)3, 12896 },
	{ (Il2CppRGCTXDataType)3, 4813 },
	{ (Il2CppRGCTXDataType)3, 4814 },
	{ (Il2CppRGCTXDataType)3, 4825 },
	{ (Il2CppRGCTXDataType)3, 228 },
	{ (Il2CppRGCTXDataType)3, 227 },
	{ (Il2CppRGCTXDataType)2, 1628 },
	{ (Il2CppRGCTXDataType)2, 1698 },
	{ (Il2CppRGCTXDataType)3, 4815 },
	{ (Il2CppRGCTXDataType)2, 1645 },
	{ (Il2CppRGCTXDataType)2, 1717 },
	{ (Il2CppRGCTXDataType)3, 230 },
	{ (Il2CppRGCTXDataType)2, 674 },
	{ (Il2CppRGCTXDataType)2, 782 },
	{ (Il2CppRGCTXDataType)3, 226 },
	{ (Il2CppRGCTXDataType)3, 229 },
	{ (Il2CppRGCTXDataType)3, 199 },
	{ (Il2CppRGCTXDataType)2, 2637 },
	{ (Il2CppRGCTXDataType)3, 11559 },
	{ (Il2CppRGCTXDataType)2, 1625 },
	{ (Il2CppRGCTXDataType)2, 1696 },
	{ (Il2CppRGCTXDataType)3, 11560 },
	{ (Il2CppRGCTXDataType)3, 201 },
	{ (Il2CppRGCTXDataType)2, 505 },
	{ (Il2CppRGCTXDataType)2, 778 },
	{ (Il2CppRGCTXDataType)3, 198 },
	{ (Il2CppRGCTXDataType)3, 200 },
	{ (Il2CppRGCTXDataType)3, 256 },
	{ (Il2CppRGCTXDataType)3, 257 },
	{ (Il2CppRGCTXDataType)2, 2639 },
	{ (Il2CppRGCTXDataType)3, 11561 },
	{ (Il2CppRGCTXDataType)2, 1631 },
	{ (Il2CppRGCTXDataType)2, 1700 },
	{ (Il2CppRGCTXDataType)3, 11562 },
	{ (Il2CppRGCTXDataType)3, 259 },
	{ (Il2CppRGCTXDataType)2, 508 },
	{ (Il2CppRGCTXDataType)2, 785 },
	{ (Il2CppRGCTXDataType)3, 255 },
	{ (Il2CppRGCTXDataType)3, 258 },
	{ (Il2CppRGCTXDataType)3, 4228 },
	{ (Il2CppRGCTXDataType)2, 1258 },
	{ (Il2CppRGCTXDataType)2, 3403 },
	{ (Il2CppRGCTXDataType)3, 11556 },
	{ (Il2CppRGCTXDataType)3, 11557 },
	{ (Il2CppRGCTXDataType)2, 1759 },
	{ (Il2CppRGCTXDataType)3, 11558 },
	{ (Il2CppRGCTXDataType)2, 416 },
	{ (Il2CppRGCTXDataType)2, 779 },
	{ (Il2CppRGCTXDataType)3, 211 },
	{ (Il2CppRGCTXDataType)3, 10229 },
	{ (Il2CppRGCTXDataType)2, 1000 },
	{ (Il2CppRGCTXDataType)3, 1149 },
	{ (Il2CppRGCTXDataType)3, 10234 },
	{ (Il2CppRGCTXDataType)3, 3365 },
	{ (Il2CppRGCTXDataType)2, 540 },
	{ (Il2CppRGCTXDataType)3, 10230 },
	{ (Il2CppRGCTXDataType)2, 2547 },
	{ (Il2CppRGCTXDataType)3, 1185 },
	{ (Il2CppRGCTXDataType)2, 1015 },
	{ (Il2CppRGCTXDataType)2, 1216 },
	{ (Il2CppRGCTXDataType)3, 3371 },
	{ (Il2CppRGCTXDataType)3, 10231 },
	{ (Il2CppRGCTXDataType)3, 3360 },
	{ (Il2CppRGCTXDataType)3, 3361 },
	{ (Il2CppRGCTXDataType)3, 3359 },
	{ (Il2CppRGCTXDataType)3, 3362 },
	{ (Il2CppRGCTXDataType)2, 1212 },
	{ (Il2CppRGCTXDataType)2, 3366 },
	{ (Il2CppRGCTXDataType)3, 4812 },
	{ (Il2CppRGCTXDataType)3, 3364 },
	{ (Il2CppRGCTXDataType)2, 1561 },
	{ (Il2CppRGCTXDataType)3, 3363 },
	{ (Il2CppRGCTXDataType)2, 1491 },
	{ (Il2CppRGCTXDataType)2, 3322 },
	{ (Il2CppRGCTXDataType)2, 1605 },
	{ (Il2CppRGCTXDataType)2, 1680 },
	{ (Il2CppRGCTXDataType)3, 4211 },
	{ (Il2CppRGCTXDataType)2, 1252 },
	{ (Il2CppRGCTXDataType)3, 5166 },
	{ (Il2CppRGCTXDataType)3, 5167 },
	{ (Il2CppRGCTXDataType)3, 5172 },
	{ (Il2CppRGCTXDataType)2, 1754 },
	{ (Il2CppRGCTXDataType)3, 5169 },
	{ (Il2CppRGCTXDataType)3, 15333 },
	{ (Il2CppRGCTXDataType)2, 1220 },
	{ (Il2CppRGCTXDataType)3, 3384 },
	{ (Il2CppRGCTXDataType)1, 1558 },
	{ (Il2CppRGCTXDataType)2, 3332 },
	{ (Il2CppRGCTXDataType)3, 5168 },
	{ (Il2CppRGCTXDataType)1, 3332 },
	{ (Il2CppRGCTXDataType)1, 1754 },
	{ (Il2CppRGCTXDataType)2, 3401 },
	{ (Il2CppRGCTXDataType)2, 3332 },
	{ (Il2CppRGCTXDataType)3, 5173 },
	{ (Il2CppRGCTXDataType)3, 5171 },
	{ (Il2CppRGCTXDataType)3, 5170 },
	{ (Il2CppRGCTXDataType)2, 355 },
	{ (Il2CppRGCTXDataType)3, 3394 },
	{ (Il2CppRGCTXDataType)2, 520 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	161,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	52,
	s_rgctxIndices,
	256,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
