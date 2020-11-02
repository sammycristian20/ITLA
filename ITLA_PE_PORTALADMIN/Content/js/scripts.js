

/*! Select */
$(document).ready(function () {
  $('.mdb-select').materialSelect();
  $("#license").addClass("mdb-select price-select");
  // $("#billing_country").addClass("mdb-select");
  $("#license").hide();
  // $("#billing_country").hide();

  // Animations init
  new WOW().init();

  // Technology switch
  // var locationPathname = window.location.pathname;
  // if (locationPathname.indexOf('docs/') !== -1) {
  //   var technologies = [
  //     { name: 'angular', url: locationPathname.replace(/docs\/angular|docs\/jquery|docs\/react|docs\/vue/gi, 'docs/angular') },
  //     { name: 'react', url: locationPathname.replace(/docs\/angular|docs\/jquery|docs\/react|docs\/vue/gi, 'docs/react') },
  //     { name: 'vue', url: locationPathname.replace(/docs\/angular|docs\/jquery|docs\/react|docs\/vue/gi, 'docs/vue') },
  //     { name: 'jquery', url: locationPathname.replace(/docs\/angular|docs\/jquery|docs\/react|docs\/vue/gi, 'docs/jquery') }
  //   ];
  //   technologies.forEach(function (item) {
  //     $.ajax({
  //       url: item.url,
  //       method: "GET"
  //     }).done(function () {
  //       $('a.switch-to-mdb-' + item.name).attr('href', item.url);
  //     });
  //   });
  // }
});