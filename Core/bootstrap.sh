#!/bin/bash  -x

mkdir  -p  .Config

/bin/bash  -x  setuplinks.sh

aclocal  -I  .Config  \
  &&  automake  --add-missing  --copy  --foreign  \
  &&  autoconf
