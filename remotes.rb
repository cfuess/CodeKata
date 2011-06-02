%w[bradmead rknapik jimblanchard kylekhunter kkrueger jstout param2000 dayoajayi eMicBra jonathanad wendys cfuess mkmurray bobpace].each do|name|
  `git remote add #{name} git://github.com/#{name}/dwpdp.git`
end
