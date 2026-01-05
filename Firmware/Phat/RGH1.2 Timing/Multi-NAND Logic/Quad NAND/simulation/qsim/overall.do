onerror {exit -code 1}
vlib work
vcom -work work main.vho
vcom -work work quadnand_sim.vwf.vht
vsim -novopt -c -t 1ps -L maxv -L altera -L altera_mf -L 220model -L sgate -L altera_lnsim work.quadnand_vhd_vec_tst
vcd file -direction overall.msim.vcd
vcd add -internal quadnand_vhd_vec_tst/*
vcd add -internal quadnand_vhd_vec_tst/i1/*
proc simTimestamp {} {
    echo "Simulation time: $::now ps"
    if { [string equal running [runStatus]] } {
        after 2500 simTimestamp
    }
}
after 2500 simTimestamp
run -all
quit -f

