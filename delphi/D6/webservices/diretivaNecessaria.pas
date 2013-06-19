initialization
  InvRegistry.RegisterInterface(TypeInfo(IMailService), 'http://tempuri.org/', 'utf-8');
  InvRegistry.RegisterDefaultSOAPAction(TypeInfo(IMailService), 'http://tempuri.org/IMailService/%operationName%');
  InvRegistry.RegisterInvokeOptions(TypeInfo(IMailService), ioDocument);// Essa linha deve ser incluída.

