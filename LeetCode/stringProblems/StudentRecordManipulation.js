  if(operation == "delete"){
      if(prop == "name"){
          delete obj.name
      }
      if(prop == "lastName"){
          delete obj.lastName
      }
      if(prop == "city"){
          delete obj.city
      }
  }
  if(operation == "edit"){
      if(prop == "name"){
          delete obj.name;
          obj[prop] = newValue;
      }
      if(prop == "lastName"){
          delete obj.lastName;
          obj[prop] = newValue;
      }
      if(prop == "city"){
          delete obj.city;
          obj[prop] = newValue;
      }
    }
    