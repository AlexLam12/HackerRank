function lonelyinteger(a) {
  let unique = a[0];
   a.map(el => {
      let occurences = a.filter(e => e ===el).length
      if (occurences === 1){unique = el;}
   });
   return unique
}