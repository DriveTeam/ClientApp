﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Event
{
	public virtual GUID Event_ID
	{
		get;
		set;
	}

	public virtual string EventName
	{
		get;
		set;
	}

	public virtual DateTime EventDate
	{
		get;
		set;
	}

	public virtual boolean Presented
	{
		get;
		set;
	}

	public virtual boolean Attended
	{
		get;
		set;
	}

	public virtual List<User> Users
	{
		get;
		set;
	}

	public virtual IEnumerable<User> User
	{
		get;
		set;
	}

	public virtual void AttendEvent()
	{
		throw new System.NotImplementedException();
	}

	public virtual List<User> GetPresentPerson()
	{
		throw new System.NotImplementedException();
	}

	public virtual void PresentEvent()
	{
		throw new System.NotImplementedException();
	}

}

