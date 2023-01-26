namespace com.google.gson
{
	using ep;

	public interface ObjectNavigator$Visitor
	{
	  void end(ep paramep);

	  object Target {get;}

	  void start(ep paramep);

	  void startVisitingObject(object paramObject);

	  void visitArray(object paramObject, Type paramType);

	  void visitArrayField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject);

	  bool visitFieldUsingCustomHandler(FieldAttributes paramFieldAttributes, Type paramType, object paramObject);

	  void visitObjectField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject);

	  void visitPrimitive(object paramObject);

	  bool visitUsingCustomHandler(ep paramep);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\ObjectNavigator$Visitor.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}