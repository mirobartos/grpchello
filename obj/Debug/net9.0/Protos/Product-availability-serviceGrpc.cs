// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product-availability-service.proto
// </auto-generated>
// Original file comments:
// Protos/product-availability-service.proto
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProductAvailabilityService {
  public static partial class ProductAvailabilityCheck
  {
    static readonly string __ServiceName = "ProductAvailability.ProductAvailabilityCheck";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductAvailabilityService.ProductAvailabilityRequest> __Marshaller_ProductAvailability_ProductAvailabilityRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductAvailabilityService.ProductAvailabilityRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductAvailabilityService.ProductAvailabilityReply> __Marshaller_ProductAvailability_ProductAvailabilityReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductAvailabilityService.ProductAvailabilityReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductAvailabilityService.ProductAvailabilityRequest, global::ProductAvailabilityService.ProductAvailabilityReply> __Method_CheckProductAvailabilityRequest = new grpc::Method<global::ProductAvailabilityService.ProductAvailabilityRequest, global::ProductAvailabilityService.ProductAvailabilityReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckProductAvailabilityRequest",
        __Marshaller_ProductAvailability_ProductAvailabilityRequest,
        __Marshaller_ProductAvailability_ProductAvailabilityReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProductAvailabilityService.ProductAvailabilityServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductAvailabilityCheck</summary>
    [grpc::BindServiceMethod(typeof(ProductAvailabilityCheck), "BindService")]
    public abstract partial class ProductAvailabilityCheckBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductAvailabilityService.ProductAvailabilityReply> CheckProductAvailabilityRequest(global::ProductAvailabilityService.ProductAvailabilityRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductAvailabilityCheckBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CheckProductAvailabilityRequest, serviceImpl.CheckProductAvailabilityRequest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductAvailabilityCheckBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CheckProductAvailabilityRequest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductAvailabilityService.ProductAvailabilityRequest, global::ProductAvailabilityService.ProductAvailabilityReply>(serviceImpl.CheckProductAvailabilityRequest));
    }

  }
}
#endregion
