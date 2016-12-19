<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoundTable.aspx.cs" Inherits="Learn2Read.SoundTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Доска звуков</title>
    <link rel="stylesheet" type="text/css" href="soundtable.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="topmenu"><h1>Доска звуков</h1></div>
        <div id="workBoard">
    <div id ="sounds">
        
            <div id="vovels">
            <h2>Vovels</h2>
             <div id="short">
             <p id ="shortP"> Short<asp:ImageButton ID="HintShort" runat="server" ImageUrl="../images/soundtable/hint.png" Height="30px" Width="30px" OnClick="ShowHintShort_Click"/></p>
             <asp:ImageButton ID="I" runat="server" ImageUrl="../images/soundtable/i.png" Height="60px" Width="60px" OnClick="I_Click"/>
             <asp:ImageButton ID="U" runat="server" ImageUrl="../images/soundtable/u.png" Height="60px" Width="60px" OnClick="U_Click"/>
             <asp:ImageButton ID="A" runat="server" ImageUrl="../images/soundtable/a.png" Height="60px" Width="60px" OnClick="A_Click" />
             <asp:ImageButton ID="Arev" runat="server" ImageUrl="../images/soundtable/areverse.png" Height="60px" Width="60px" OnClick="Arev_Click" />
             <asp:ImageButton ID="Erev" runat="server" ImageUrl="../images/soundtable/ereverse.png" Height="60px" Width="60px" OnClick="Erev_Click" />
             <asp:ImageButton ID="E" runat="server" ImageUrl="../images/soundtable/e.png" Height="60px" Width="60px" OnClick="E_Click" />
             <asp:ImageButton ID="Frog" runat="server" ImageUrl="../images/soundtable/frog.png" Height="60px" Width="60px" OnClick="Frog_Click" />
             </div>
                 <div id="long">   
             <p>Long</p>
             <asp:ImageButton ID="Ilong" runat="server" ImageUrl="../images/soundtable/ilong.png" Height="60px" Width="60px"  OnClick="Ilong_Click" />
             <asp:ImageButton ID="Ulong" runat="server" ImageUrl="../images/soundtable/ulong.png" Height="60px" Width="60px"  OnClick="Ulong_Click" />
             <asp:ImageButton ID="Along" runat="server" ImageUrl="../images/soundtable/along.png" Height="60px" Width="60px"  OnClick="Along_Click" />
             <asp:ImageButton ID="Olong" runat="server" ImageUrl="../images/soundtable/olong.png" Height="60px" Width="60px" OnClick="Olong_Click" />
             <asp:ImageButton ID="ErevLong" runat="server" ImageUrl="../images/soundtable/ereverselong.png" Height="60px" Width="60px"  OnClick="Erevlong_Click" />
              </div>
                 <div id="diphthongs">  
             <p>Diphthongs</p>
             <asp:ImageButton ID="ie" runat="server" ImageUrl="../images/soundtable/ie.png" Height="60px" Width="60px"  OnClick="ie_Click"/>
             <asp:ImageButton ID="ue" runat="server" ImageUrl="../images/soundtable/ue.png" Height="60px" Width="60px"  OnClick="ue_Click"/>
             <asp:ImageButton ID="ai" runat="server" ImageUrl="../images/soundtable/ai.png" Height="60px" Width="60px"   OnClick="ai_Click"/>
             <asp:ImageButton ID="oi" runat="server" ImageUrl="../images/soundtable/oi.png" Height="60px" Width="60px"  OnClick="oi_Click" />
             <asp:ImageButton ID="ErevU" runat="server" ImageUrl="../images/soundtable/ereverseu.png" Height="60px" Width="60px"  OnClick="ErevU_Click" />
             <asp:ImageButton ID="ErevE" runat="server" ImageUrl="../images/soundtable/ereversee.png" Height="60px" Width="60px"   OnClick="ErevE_Click"/>
             <asp:ImageButton ID="au" runat="server" ImageUrl="../images/soundtable/au.png" Height="60px" Width="60px"  OnClick="au_Click"/>
             <asp:ImageButton ID="ei" runat="server" ImageUrl="../images/soundtable/ei.png" Height="60px" Width="60px"  OnClick="ei_Click" />
              </div>  
              </div>
        <div id="consonants">
            <h2>Consonants</h2>
            <p>Voiceless</p>
             <asp:ImageButton ID="p" runat="server" ImageUrl="../images/soundtable/p.png" Height="60px" Width="60px"  OnClick="p_Click"/>
             <asp:ImageButton ID="t" runat="server" ImageUrl="../images/soundtable/t.png" Height="60px" Width="60px" OnClick="t_Click"/>
             <asp:ImageButton ID="ts" runat="server" ImageUrl="../images/soundtable/ts.png" Height="60px" Width="60px" OnClick="ts_Click"/>
             <asp:ImageButton ID="k" runat="server" ImageUrl="../images/soundtable/k.png" Height="60px" Width="60px" OnClick="k_Click"/>
             <asp:ImageButton ID="f" runat="server" ImageUrl="../images/soundtable/f.png" Height="60px" Width="60px"  OnClick="f_Click"/>
             <asp:ImageButton ID="th" runat="server" ImageUrl="../images/soundtable/th.png" Height="60px" Width="60px" OnClick="th_Click"/>
             <asp:ImageButton ID="s" runat="server" ImageUrl="../images/soundtable/s.png" Height="60px" Width="60px" OnClick="s_Click"/>
             <asp:ImageButton ID="sh" runat="server" ImageUrl="../images/soundtable/sh.png" Height="60px" Width="60px" OnClick="sh_Click"/>
            <p>Voiced</p>
             <asp:ImageButton ID="b" runat="server"  ImageUrl="../images/soundtable/b.png" Height="60px" Width="60px" OnClick="b_Click"/>
             <asp:ImageButton ID="d" runat="server" ImageUrl="../images/soundtable/d.png" Height="60px" Width="60px" OnClick="d_Click"/>
             <asp:ImageButton ID="dz" runat="server" ImageUrl="../images/soundtable/dz.png" Height="60px" Width="60px" OnClick="dz_Click"/>
             <asp:ImageButton ID="g" runat="server" ImageUrl="../images/soundtable/g.png" Height="60px" Width="60px" OnClick="g_Click"/>
             <asp:ImageButton ID="v" runat="server" ImageUrl="../images/soundtable/v.png" Height="60px" Width="60px"  OnClick="v_Click"/>
             <asp:ImageButton ID="thVoiced" runat="server" ImageUrl="../images/soundtable/thvoiced.png" Height="60px" Width="60px" OnClick="thVoiced_Click"/>
             <asp:ImageButton ID="z" runat="server" ImageUrl="../images/soundtable/z.png" Height="60px" Width="60px" OnClick="z_Click"/>
             <asp:ImageButton ID="dzz" runat="server" ImageUrl="../images/soundtable/dzz.png" Height="60px" Width="60px" OnClick="dzz_Click"/>
             <asp:ImageButton ID="m" runat="server" ImageUrl="../images/soundtable/m.png" Height="60px" Width="60px" OnClick="m_Click"/>
             <asp:ImageButton ID="n" runat="server" ImageUrl="../images/soundtable/n.png" Height="60px" Width="60px" OnClick="n_Click"/>
             <asp:ImageButton ID="nnose" runat="server" ImageUrl="../images/soundtable/nnose.png" Height="60px" Width="60px" OnClick="nnose_Click"/>
             <asp:ImageButton ID="h" runat="server" ImageUrl="../images/soundtable/h.png" Height="60px" Width="60px" OnClick="h_Click"/>
             <asp:ImageButton ID="l" runat="server" ImageUrl="../images/soundtable/l.png" Height="60px" Width="60px"  OnClick="l_Click"/>
             <asp:ImageButton ID="r" runat="server" ImageUrl="../images/soundtable/r.png" Height="60px" Width="60px" OnClick="r_Click"/>
             <asp:ImageButton ID="w" runat="server" ImageUrl="../images/soundtable/w.png" Height="60px" Width="60px" OnClick="w_Click"/>
             <asp:ImageButton ID="j" runat="server" ImageUrl="../images/soundtable/j.png" Height="60px" Width="60px" OnClick="j_Click"/>
        </div>
    </div>
        <div id="explanation">
            <div id="controllElements">
            <div id ="selectedItemDiv">
            <h2>Selected Item</h2>
                </div>
            <div id="currentSoundDiv">
            <asp:Image ID="CurrentSound" runat="server" ImageUrl="../images/Background/empty.png" Height="60px" Width="60px"></asp:Image>
                </div>
                <div id="menu">
            <asp:PlaceHolder ID="Menu" runat="server"></asp:PlaceHolder><br/><br/>
                    </div>
                </div>
            <asp:PlaceHolder ID="CurrentElement" runat="server"></asp:PlaceHolder>   
        </div>
        </div>

        
        
    </form>
</body>
</html>
