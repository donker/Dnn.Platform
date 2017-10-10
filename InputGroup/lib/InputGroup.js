!function(e,t){"object"==typeof exports&&"object"==typeof module?module.exports=t(require("react")):"function"==typeof define&&define.amd?define(["react"],t):"object"==typeof exports?exports.InputGroup=t(require("react")):e.InputGroup=t(e.react)}(this,function(e){return function(e){function t(n){if(r[n])return r[n].exports;var o=r[n]={exports:{},id:n,loaded:!1};return e[n].call(o.exports,o,o.exports,t),o.loaded=!0,o.exports}var r={};return t.m=e,t.c=r,t.p="",t(0)}([function(e,t,r){"use strict";function n(e){return e&&e.__esModule?e:{"default":e}}Object.defineProperty(t,"__esModule",{value:!0});var o=Object.assign||function(e){for(var t=1;t<arguments.length;t++){var r=arguments[t];for(var n in r)Object.prototype.hasOwnProperty.call(r,n)&&(e[n]=r[n])}return e},i=r(5),a=n(i);r(4);var s=function(e){return a["default"].createElement("div",o({},e,{className:"dnn-ui-common-input-group"}))};t["default"]=s},function(e,t,r){t=e.exports=r(2)(),t.push([e.id,".dnn-ui-common-input-group{position:relative;display:block;border-collapse:separate;width:100%}.dnn-ui-common-input-group .input-group-addon{border-right:0;border-radius:3px;padding:8px 16px;border:1px solid #ccc;border-right:none;color:#b3b3b3;text-align:center;width:1%;white-space:nowrap;vertical-align:middle;display:table-cell;box-sizing:border-box;border-collapse:separate;border-top-right-radius:0;border-bottom-right-radius:0}.dnn-ui-common-input-group input{border-top-left-radius:0;border-bottom-left-radius:0;display:table-cell;position:relative;float:left;width:100%;border-collapse:separate}",""])},function(e,t){e.exports=function(){var e=[];return e.toString=function(){for(var e=[],t=0;t<this.length;t++){var r=this[t];r[2]?e.push("@media "+r[2]+"{"+r[1]+"}"):e.push(r[1])}return e.join("")},e.i=function(t,r){"string"==typeof t&&(t=[[null,t,""]]);for(var n={},o=0;o<this.length;o++){var i=this[o][0];"number"==typeof i&&(n[i]=!0)}for(o=0;o<t.length;o++){var a=t[o];"number"==typeof a[0]&&n[a[0]]||(r&&!a[2]?a[2]=r:r&&(a[2]="("+a[2]+") and ("+r+")"),e.push(a))}},e}},function(e,t,r){function n(e,t){for(var r=0;r<e.length;r++){var n=e[r],o=d[n.id];if(o){o.refs++;for(var i=0;i<o.parts.length;i++)o.parts[i](n.parts[i]);for(;i<n.parts.length;i++)o.parts.push(p(n.parts[i],t))}else{for(var a=[],i=0;i<n.parts.length;i++)a.push(p(n.parts[i],t));d[n.id]={id:n.id,refs:1,parts:a}}}}function o(e){for(var t=[],r={},n=0;n<e.length;n++){var o=e[n],i=o[0],a=o[1],s=o[2],u=o[3],p={css:a,media:s,sourceMap:u};r[i]?r[i].parts.push(p):t.push(r[i]={id:i,parts:[p]})}return t}function i(e,t){var r=b(),n=y[y.length-1];if("top"===e.insertAt)n?n.nextSibling?r.insertBefore(t,n.nextSibling):r.appendChild(t):r.insertBefore(t,r.firstChild),y.push(t);else{if("bottom"!==e.insertAt)throw new Error("Invalid value for parameter 'insertAt'. Must be 'top' or 'bottom'.");r.appendChild(t)}}function a(e){e.parentNode.removeChild(e);var t=y.indexOf(e);t>=0&&y.splice(t,1)}function s(e){var t=document.createElement("style");return t.type="text/css",i(e,t),t}function u(e){var t=document.createElement("link");return t.rel="stylesheet",i(e,t),t}function p(e,t){var r,n,o;if(t.singleton){var i=g++;r=m||(m=s(t)),n=c.bind(null,r,i,!1),o=c.bind(null,r,i,!0)}else e.sourceMap&&"function"==typeof URL&&"function"==typeof URL.createObjectURL&&"function"==typeof URL.revokeObjectURL&&"function"==typeof Blob&&"function"==typeof btoa?(r=u(t),n=f.bind(null,r),o=function(){a(r),r.href&&URL.revokeObjectURL(r.href)}):(r=s(t),n=l.bind(null,r),o=function(){a(r)});return n(e),function(t){if(t){if(t.css===e.css&&t.media===e.media&&t.sourceMap===e.sourceMap)return;n(e=t)}else o()}}function c(e,t,r,n){var o=r?"":n.css;if(e.styleSheet)e.styleSheet.cssText=x(t,o);else{var i=document.createTextNode(o),a=e.childNodes;a[t]&&e.removeChild(a[t]),a.length?e.insertBefore(i,a[t]):e.appendChild(i)}}function l(e,t){var r=t.css,n=t.media;t.sourceMap;if(n&&e.setAttribute("media",n),e.styleSheet)e.styleSheet.cssText=r;else{for(;e.firstChild;)e.removeChild(e.firstChild);e.appendChild(document.createTextNode(r))}}function f(e,t){var r=t.css,n=(t.media,t.sourceMap);n&&(r+="\n/*# sourceMappingURL=data:application/json;base64,"+btoa(unescape(encodeURIComponent(JSON.stringify(n))))+" */");var o=new Blob([r],{type:"text/css"}),i=e.href;e.href=URL.createObjectURL(o),i&&URL.revokeObjectURL(i)}var d={},h=function(e){var t;return function(){return"undefined"==typeof t&&(t=e.apply(this,arguments)),t}},v=h(function(){return/msie [6-9]\b/.test(window.navigator.userAgent.toLowerCase())}),b=h(function(){return document.head||document.getElementsByTagName("head")[0]}),m=null,g=0,y=[];e.exports=function(e,t){t=t||{},"undefined"==typeof t.singleton&&(t.singleton=v()),"undefined"==typeof t.insertAt&&(t.insertAt="bottom");var r=o(e);return n(r,t),function(e){for(var i=[],a=0;a<r.length;a++){var s=r[a],u=d[s.id];u.refs--,i.push(u)}if(e){var p=o(e);n(p,t)}for(var a=0;a<i.length;a++){var u=i[a];if(0===u.refs){for(var c=0;c<u.parts.length;c++)u.parts[c]();delete d[u.id]}}}};var x=function(){var e=[];return function(t,r){return e[t]=r,e.filter(Boolean).join("\n")}}()},function(e,t,r){var n=r(1);"string"==typeof n&&(n=[[e.id,n,""]]);r(3)(n,{});n.locals&&(e.exports=n.locals)},function(t,r){t.exports=e}])});