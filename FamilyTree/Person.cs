
using System;

namespace FamilyTree
{
	
	
	public class Person
	{
		/**
		 * PersonID
		 * Purpose: Property, gets and sets PersonID
		 * Preconditions: Nonef
		 * Postconditions: None
		 * Parameters: 
		 * Returns: PersonID
		 **/ 
		public int PersonID {
			get {
				/*if(PersonID == null) {
					return PersonID;
				}
				else {
					return PersonID;
				}*/
				return PersonID;
			}
			set {
			}
		}
		
		/**
		 * FirstName
		 * Purpose: Property, gets and sets FirstName
		 * Preconditions: None
		 * Postconditions: None
		 * Parameters: 
		 * Returns: FirstName
		 **/ 
		public string FirstName {
			get {
				/*if(FirstName == null) {
					return FirstName;
				}
				else {
					return FirstName;
				}*/
				return FirstName;
			}
			set {}
		}
		
		/**
		 * MiddleName
		 * Purpose: Property, gets and sets MiddleName
		 * Preconditions: None
		 * Postconditions: None
		 * Parameters: 
		 * Returns: MiddleName
		 **/ 
		public string MiddleName {
			get {
				if(MiddleName == null) {
					return MiddleName;
				}
				else {
					return MiddleName;
				}
			}
			set {}
		}
		
		/**
		 * LastName
		 * Purpose: Property, gets and sets LastName
		 * Preconditions: None
		 * Postconditions: None
		 * Parameters: 
		 * Returns: LastName
		 **/ 
		public string LastName {
			get {
				if(LastName == null) {
					return LastName;
				}
				else {
					return LastName;
				}
			}
			set {}
		}
		
		/**
		 * BirthDate
		 * Purpose: Property, gets and sets BirthDate
		 * Preconditions: None
		 * Postconditions: None
		 * Parameters: 
		 * Returns: BirthDate
		 **/ 
		public DateTime BirthDate {
			get {
				/*if(BirthDate == null) {
					return BirthDate;
				}
				else {
					return BirthDate;
				}*/
				return BirthDate;
			}
			set {}
		}
		
		/**
		 * DeathDate
		 * Purpose: Property, gets and sets DeathDate
		 * Preconditions: None
		 * Postconditions: None
		 * Parameters: 
		 * Returns: DeathDate
		 **/ 
		public DateTime DeathDate {
			get {
				/*if(DeathDate == null) {
					return DeathDate;
				}
				else {
					return DeathDate;
				}*/
				return DeathDate;
			}
			set {}
		}
		
		/**
		 * Person
		 * Purpose: Constructor, sets all parameters to null
		 * Preconditions: None
		 * Postconditions: None
		 * Perameters: None
		 * Returns: None
		 **/
		public Person() {
			PersonID = 0;
			FirstName = null;
			MiddleName = null;
			LastName = null;
			//BirthDate = null;
			//DeathDate = null;
		}
		
		public void QuereyDatabase(string querey) {
			
		}
	}
}
