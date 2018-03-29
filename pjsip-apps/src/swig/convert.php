<?php

$file = file_get_contents ( 'symbols.i' );
//preg_match_all("/\(\((?:\('(.)'\s<<\s(\d+)\)?\s\|\s)(?:\('(.)'\s<<\s(\d+)\)\)?\s\|\s)(?:\('(.)'\s<<\s(\d+)\)\)?\s\|\s)'(\s|\w)?'/", $file, $out, PREG_SET_ORDER );
$out = preg_replace_callback("/\(\((?:\('(.)'\s<<\s(\d+)\)?\s\|\s)(?:\('(.)'\s<<\s(\d+)\)\)?\s\|\s)(?:\('(.)'\s<<\s(\d+)\)\)?\s\|\s)'(\s|\w)?'/", "enum_pack", $file);
function enum_pack($matches){
	$result = ord($matches[7]) << 24 | ord($matches[5]) << 16 | ord($matches[3]) << 8 | ord($matches[1]);
	return $result;
}

file_put_contents('symbols_csharp.i', $out);